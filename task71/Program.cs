// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 3 -> A(m,n) = 29

int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}
int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if(m != 0 && n == 0) return AkkermanFunc(m - 1, 1);
    else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.WriteLine("Вычисление функции Аккермана. задайте два неотрицательных числа m и n.");
Console.WriteLine("Введите число m");
int a = InputExamNumber();
Console.WriteLine("Введите число n");
int b = InputExamNumber();
Console.WriteLine($"A({a},{b}) = {AkkermanFunc(a, b)}");