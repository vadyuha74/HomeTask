// Написать программу масштабирования фигуры

int[,] AddPointToArray() //Ввод точек и преобразование в массив
{
    Console.WriteLine("Введите точки фигуры в виде (0,0) (2,0) (2,2) (0,2)");
    string[] text = Console.ReadLine().Replace(")", "").Replace("(", "").Split(" ");
    int[,] array = new int[text.Length, 2];
    for (int i = 0; i < text.Length; i++)
    {
        string[] point = text[i].Split(",");
        array[i, 0] = Convert.ToInt32(point[0]);
        array[i, 1] = Convert.ToInt32(point[1]);
    }
    return array;
}

void PrintPoints(int[,] matr) // Вывод точек
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
            Console.Write($"({matr[i, 0]},{matr[i, 1]})");
    }
    Console.WriteLine();
}

int[,] ScaleArray(int[,] matr, int k) // Умножение массива на число
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
int[,] arrayPoint = AddPointToArray();
Console.Write("Введите коэффициэнт масштабирования:");
int scale = int.Parse(Console.ReadLine());
arrayPoint = ScaleArray(arrayPoint, scale);
PrintPoints(arrayPoint);