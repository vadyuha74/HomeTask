// В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

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

void PrintArray(int[,] matr)
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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void FindNumber(int[,] matr, int value)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == value)
            {
                Console.WriteLine($"{count + 1} позиция числа: строка {i+1} и столбец {j+1}");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine("Такого элемента нет");
}

Console.WriteLine("Введите количество строк");
int m = InputExamNumber();
Console.WriteLine("Введите количество столбцов");
int n = InputExamNumber();
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите число");
int x = InputExamNumber();
FindNumber(array, x);