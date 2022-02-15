// Найти кубы чисел от 1 до N
int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        Console.Write("Введите число: ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
        Console.WriteLine("Вы ввели число {0}", number);
        return number;
        break;
        }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}
int a = InputExamNumber();
for(int i = 1; i <= a; i++)
{
    Console.WriteLine($"куб числа - {i} равен - {i * i * i}");
}