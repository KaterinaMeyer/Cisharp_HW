Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"Число {a} больше чем число {b}:");
}
else
{
    Console.Write($"Число {b} больше чем число {a}:");
}

