// Показать четные чила от 1 до N
int N = new Random().Next(1, 100);
Console.WriteLine("Случайное число - " + N);
if (N%2 != 0) N = N - 1;
while (N > 1)
{
    Console.WriteLine(N);
    N = N - 2;
}