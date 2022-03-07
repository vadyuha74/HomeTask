// Спирально заполнить двумерный массив:

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

int NumberSpiral(int n, int m, int i, int j) // заполнение матрицы
{
    return j > 0 ? n + NumberSpiral(m - 1, n, j - 1, n - i - 1) : i + 1;
}
//return j > 0 ? n + NumberSpiral(m - 1, n, j - 1, n - i - 1) : i + 1;

Console.WriteLine("Введите количество строк:");
int row = InputExamNumber();
Console.WriteLine("Введите количество столбцов:");
int column = InputExamNumber();
int[,] matr=new int[row,column];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        matr[i,j]= NumberSpiral(row, column, i, j);
    }  
}
Console.WriteLine();
PrintArray(matr);