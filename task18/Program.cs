// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool X = (new Random().Next(0,2) == 0);// задаем рандомное логическим пременным
Console.WriteLine($"X = {X}");
bool Y = (new Random().Next(0,2) == 0);
Console.WriteLine($"Y = {Y}");
if (!(X || Y) == (!X && !Y)) Console.WriteLine("утверждение верно");
else Console.WriteLine("утверждение неверно");