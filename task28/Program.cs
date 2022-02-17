// Подсчитайте сумму цифр в числе.
int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        Console.Write("Введите число: ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            Console.WriteLine("Вы ввели число: " + number);
            return number;
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}
int QuantDigital(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}
int a = InputExamNumber();
a = QuantDigital(a);
Console.WriteLine("Количество цифр: " + a);