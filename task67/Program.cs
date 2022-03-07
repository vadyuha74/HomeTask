// Показать натуральные числа от N до 1, N задано.
//N = 5. -> "5, 4, 3, 2, 1"

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

string NumbersString(int n)
{
    return (n > 1) ? $"{n}, " + NumbersString(n - 1) : "1";
}
Console.WriteLine("Введите число:");
int m = InputExamNumber();
Console.WriteLine(NumbersString(m));