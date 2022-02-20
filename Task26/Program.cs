// Возведение число А в целую степень B используя цикл
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
double Exponent(int a, int b) // возведенеие в степень
{
    double c = 1;
    if (b > 0)
    {
        for (int i = 0; i < b; i++)
        {
            c *= a;
        }
    }
    else
    {
        for (int i = 0; i < -b; i++)
        {
            c /= a;
        }
    }
    return c;
}
int a, b;
Console.WriteLine("Возведение числа А в целую степень B");
Console.WriteLine("Введите число А");
a = InputExamNumber();
Console.WriteLine("Введите число B");
b = InputExamNumber();
Console.WriteLine("результат равен: " + Exponent(a, b));