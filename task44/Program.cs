// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

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
bool ChoiceUsers() // выбор пользователя
{
    while (true)
    {
        Console.WriteLine("Если согласны введите Y, в обратном случае нажмите N");
        string text = Console.ReadLine();
        if (text == "Y" || text =="y")
        {
            return true;
            break;
        }
        if (text == "N" || text =="n")
        {
            return false;
            break;
        }
        else Console.WriteLine("Не удалось распознать ответ, попробуйте еще раз.");
    }
}
int[] InpArrayHowString()
{
    
    Console.WriteLine("Введите числа через запятую, в виде 1,2,3,4");
    string text = Console.ReadLine().Split(",");
    for (int i = 0; i < text.length; i++)
    {
        
    }
}
int[] arr = new int[4];
Console.WriteLine("Находим точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Хотите задать k1, b1, k2, b2? В другом случае точки будут случайными");
if (ChoiceUsers())
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Введите k{i}");
        arr[i]=InputExamNumber();
        Console.WriteLine($"Введите b{i}");
        arr[i+1]=InputExamNumber();
    }

}
else Console.WriteLine("Досвидания");
/*double y = (k2 * b1 / k1 + b2) / (1 - k2 / k1);
double x = (y - b1) / k1;*/