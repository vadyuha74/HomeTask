// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] arr, int a, int b) //заполняем массив числами  [а ; b)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
}

void OutputArray(int[] arr) //печать массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int SummOddsArray(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) summ += arr[i];
    }
    return summ;
}

int[] array = new int[24];
Console.WriteLine("Задан массив");
FillArray(array, 1, 100);
OutputArray(array);
Console.WriteLine($"Сумма нечетных элементов массива равна: {SummOddsArray(array)}");