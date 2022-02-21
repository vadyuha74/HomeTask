// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(double[] arr) //заполняем массив вещесвенными числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }
}

void OutputArray(double[] arr) //печать массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("{0} ", arr[i]);
    }
}

void DiffMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Максимальный элемент: {max}, минимальный элемент: {min} и разница: {max - min}");
}

double[] array = new double[25];
FillArray(array);
Console.WriteLine("Задан массив");
OutputArray(array);
DiffMaxMin(array);