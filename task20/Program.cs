// Задать номер четверти, показать диапазоны для возможных координат
int N = new Random().Next(1, 5);
Console.WriteLine(" Дана четверть № " + N);
if (N < 3)
{
     if (N == 2)Console.WriteLine("Соответсвенно x =(0 , ∞) и y =(0 , -∞)");
     else Console.WriteLine("Соответсвенно x =(0 , ∞) и y =(0 , ∞)");
} 
else
{
    if (N == 3)Console.WriteLine("Соответсвенно x =(0 , -∞) и y =(0 , -∞)");  
    else Console.WriteLine("Соответсвенно x =(0 , -∞) и y =(0 , ∞)");
}
    
