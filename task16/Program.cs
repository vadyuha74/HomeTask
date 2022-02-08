// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int N = new Random().Next(1, 8);
Console.WriteLine(" Дано: " + N);
if (N == 6 || N == 7) Console.WriteLine("Это выходной");
else Console.WriteLine("Это рабочий день");