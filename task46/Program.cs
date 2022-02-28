// Написать программу масштабирования фигуры

double[,] AddPointToArray() //Ввод точек и преобразование в массив
{
    Console.WriteLine("Введите точки фигуры в виде (0,0) (2,0) (2,2) (0,2)");
    string[] text = Console.ReadLine().Replace(")", "").Replace("(", "").Split(" ");
    double[,] array = new double[text.Length, 2];
    for (int i = 0; i < text.Length; i++)
    {
        string[] point = text[i].Split(",");
        array[i, 0] = Convert.ToDouble(point[0]);
        array[i, 1] = Convert.ToDouble(point[1]);
    }
    return array;
}

void PrintPoints(double[,] matr) // Вывод точек
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
            Console.Write($"({matr[i, 0]},{matr[i, 1]})");
    }
    Console.WriteLine();
}

double[,] ScaleArray(double[,] matr, double k) // Умножение массива на число
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] *= k;
        }
    }
    return matr;
}

Console.WriteLine("Программа масштабирования фигуры");
double[,] arrayPoint = AddPointToArray();
Console.Write("Введите коэффициэнт масштабирования:");
double scale = double.Parse(Console.ReadLine());
arrayPoint = ScaleArray(arrayPoint, scale);
PrintPoints(arrayPoint);