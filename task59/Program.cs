// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

void PrintArray(int[,] matr) // печать матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // Заполнение матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int NumMinSummRow(int[,] matr) // Поиск строки с наименьшей суммой элементов
{
    int position=1;
    int minsumm=0;
    for (int j = 0; j < matr.GetLength(1); j++)
        {
            minsumm += matr[0, j];
        }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int summ=0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            summ += matr[i, j];
        }
        if (summ<minsumm) 
        {
            minsumm=summ;
            position=i+1;
        }
    }
    return position;
}

Console.WriteLine("Введите количество строк");
int m = InputExamNumber();
Console.WriteLine("Введите количество столбцов");
int n = InputExamNumber();
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Задан массив");
PrintArray(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {NumMinSummRow(matrix)}");