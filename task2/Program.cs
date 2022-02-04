// Показывает наибольшее и наименьшее число из двух
int a = new Random().Next(1, 10);
Console.WriteLine(a);
int b = new Random().Next(1, 10);
Console.WriteLine(b);
if (a == b) Console.WriteLine("Числа равны");
else
{
    if (b > a)
    {
        Console.WriteLine("наибольшее число - " + b);
        Console.WriteLine("наиьеньшее число - " + a);
    }
    else
    {
    Console.WriteLine("наибольшее число - " + a);
    Console.WriteLine("наиьеньшее число - " + b);
    }
}