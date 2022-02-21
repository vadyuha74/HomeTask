// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.

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

int ColEvenNum(int[] arr) // Подсчет количества четных чисел
{
    int col = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) col++;
    }
    return col;
}

int[] array = new int[18];
Console.WriteLine("Задан массив");
FillArray(array, 100, 1000);
OutputArray(array);
Console.WriteLine($"Количество четных чисел: {ColEvenNum(array)}, соответсвенно нечетных: {array.Length-ColEvenNum(array)}");