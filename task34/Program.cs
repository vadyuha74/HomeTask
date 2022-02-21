// Написать программу для замены элементов массива на противоположные.

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

int[] array = new int[18];
Console.WriteLine("дан массив");
FillArray(array, -99, 100);
OutputArray(array);
for (int i = 0; i < array.Length; i++)
{
    array[i]=-array[i];
}
Console.WriteLine("Измененный массив");
OutputArray(array);
