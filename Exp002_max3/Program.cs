Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) 
{
    Console.WriteLine("Максимальное число = " + a);
}
else if (b > a && b > c) 
{
    Console.WriteLine("Максимальное число = " + b);
}
else {
    Console.WriteLine("Максимальное число = " + c);
}

