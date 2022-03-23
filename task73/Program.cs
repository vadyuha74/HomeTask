// Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? 
// Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.

int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}
int NumberGroups(int n)
{
    int m = Convert.ToInt32(Math.Log(n, 2));
    if (m == Math.Log(n, 2)) return m+1;
    else return m;
}

Console.WriteLine("Введите число:");
int n = InputExamNumber();
Console.WriteLine($"количество групп взаимно простых чисел={NumberGroups(n)}");
while (true)
{
    Console.WriteLine("Введите номер группы для демонстрации, не больше количества групп:");
    int m = InputExamNumber();
    if (m < NumberGroups(n) && m>0) 
    {
        Console.WriteLine($"Группа чисел №{m} это числа от {Math.Pow(2,m-1)} до {Math.Pow(2,m)-1}");
        break;
    }
    if (m == NumberGroups(n))
    {
        Console.WriteLine($"Группа чисел №{m} это числа от {Math.Pow(2,m-1)} до {n}");
        break;
    }
}
