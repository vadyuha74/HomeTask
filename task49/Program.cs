// Показать двумерный массив размером m×n, заполненный вещественными числами
int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            Console.WriteLine("Вы ввели число {0}", number);
            return number;
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble() * 100;
        }
    }
}
Console.WriteLine("Введите количество строк");
int m = InputExamNumber();
Console.WriteLine("Введите количество столбцов");
int n = InputExamNumber();
double [,] array = new double[m, n];
FillArray(array);
PrintArray(array);