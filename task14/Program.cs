// Найти третью цифру числа или сообщить, что её нет.
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
if (a < 100) Console.WriteLine("Третьей цифры нет");
else
{
     while (a >= 1000)
    {
        a = a / 10;
    }
a = a % 10;
Console.WriteLine($"третья цифра - {a}");
}