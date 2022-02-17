// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
void FillArray(int[] mass)
{
    int length = mass.Length;
    int index = 0;
    while (index < length)
    {
        mass[index] = new Random().Next(0, 2);
        index++;
    }
}
void OutputArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[] array = new int[8];
FillArray(array);
OutputArray(array);