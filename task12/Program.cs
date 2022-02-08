// Удалить вторую цифру трёхзначного числа с защитой от неправильного ввода
int DelSecondDig(int num)
{
    int dig = (num / 100) * 10 + num % 10;
    return dig;
}
// Ввод и проверка числа
int InputExamNumber()
{
    while (true)
    {
        Console.Write("Введите трехзначное число: ");
        string text = Console.ReadLine();
        if (text.Length == 3 & int.TryParse(text, out int number))
        {
        Console.WriteLine("Вы ввели число {0}", number);
        return number;
        break;
        }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}
int a = InputExamNumber();
Console.WriteLine($"Число без второй цифры - {DelSecondDig(a)}");