// Показать вторую цифру трёхзначного числа
int SecondDigit(int num)
{
    int dig = num / 10;
    dig = dig % 10;
    return dig;
}
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
Console.WriteLine($"вторая цифра - {SecondDigit(a)}");
