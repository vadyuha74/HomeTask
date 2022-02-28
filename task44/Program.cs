// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

bool ChoiceUsers() // выбор пользователя
{
    while (true)
    {
        Console.WriteLine("Если согласны введите Y, в обратном случае нажмите N");
        string text = Console.ReadLine();
        if (text == "Y" || text == "y")
        {
            return true;
            break;
        }
        if (text == "N" || text == "n")
        {
            return false;
            break;
        }
        else Console.WriteLine("Не удалось распознать ответ, попробуйте еще раз.");
    }
}

int[] InpArrayHowString() //Ввод чисел через запятую
{
    Console.WriteLine("Введите числа через запятую, в виде k1,b1,k2,b2");
    string[] text = Console.ReadLine().Split(",");
    int[] array = new int[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        array[i] = int.Parse(text[i]);
    }
    return array;
}
int[] FillArray(int leng) // запорлнение массива случайными числами
{
    int[] array = new int[leng];
    for (int i = 0; i < leng; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
int[] arr = new int[4];
Console.WriteLine("Находим точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Хотите задать k1, b1, k2, b2? В другом случае точки будут случайными");
if (ChoiceUsers()) arr = InpArrayHowString();
else arr = FillArray(4);
Console.WriteLine($"Заданы прямые y = {arr[0]} * x + {arr[1]}, y = {arr[2]} * x + {arr[3]}");
double x = (double)(arr[3] - arr[1]) / (arr[0] - arr[2]);
double y = arr[0] * x + arr[1];
Console.WriteLine($"точка пересечения х= {x}  и y={y}");