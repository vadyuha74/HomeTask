// Определить, сколько чисел больше 0 введено с клавиатуры.

int count = 0;
Console.WriteLine("Введите целое число, если ввод закончен введите n");
while (true)
{
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        if (number >0) count++;
    } 
    else 
    {
        if (text == "n") break;
        else Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}
Console.WriteLine("Количество чисел больше нуля: {0}", count);
