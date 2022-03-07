// Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
//M = 1; N = 4 -> 10
//M = 4; N = 8. -> 30

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

int NumbersSumm(int m, int n)
{
    return (n != m) ? n + NumbersSumm(m, n - 1) : m;
}
Console.WriteLine("Введите число M");
int a = InputExamNumber();
Console.WriteLine("Введите число N");
int b = InputExamNumber();
Console.WriteLine($"Сумма чисел: {NumbersSumm(a, b)}");