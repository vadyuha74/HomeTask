// Найти произведение двух матриц.
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

int[,] ProductMatrices(int[,] matr1, int[,] matr2) //произведение матриц
{
    int[,] resmatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(0); k++)
            {
                resmatr[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return resmatr;
}

Console.WriteLine("Произведение матриц количество столбцов матрицы 1 должно быть равно количеству строк матрицы 2");
Console.WriteLine("Введите количество строк матрицы 1");
int m1 = InputExamNumber();
Console.WriteLine("Введите количество столбцов матрицы 1");
int n1 = InputExamNumber();
int[,] matrix1 = new int[m1, n1];
FillArray(matrix1);
Console.WriteLine("Введите количество строк матрицы 2");
int m2 = InputExamNumber();
Console.WriteLine("Введите количество столбцов матрицы 2");
int n2 = InputExamNumber();
int[,] matrix2 = new int[m2, n2];
FillArray(matrix2);
Console.WriteLine("матрица 1");
PrintArray(matrix1);
Console.WriteLine("матрица 2");
PrintArray(matrix2);
int[,] resmatrix = new int[m1, n2];
if (m1 == n2) resmatrix = ProductMatrices(matrix1, matrix2);
else Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй");
Console.WriteLine("Результат");
PrintArray(resmatrix);