// Покажите кубы чисел, заканчивающихся на чётную цифру.
int InputExamNumber() // Ввод и проверка числа
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            Console.WriteLine("Вы ввели число " + number);
            return number;
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}
Console.WriteLine("Введите натуральное число, до него мы покажем кубы чисел заканчивающиеся на четные цифры");
int n =InputExamNumber();
for (int i = 0; i <= n; i++)
{
    if (i%2 == 0) Console.WriteLine($"куб чила {i} равен {i*i*i}");
}