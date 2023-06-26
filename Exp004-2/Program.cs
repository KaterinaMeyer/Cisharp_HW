// 16 Напишите программу, которая принимает на вход два числа и проверяет,
    // является ли одно число квадратом другого.

    // 5, 25  ->  да
    // 25, 5  ->  да
    // 8,9  ->  нет

Console.Clear();

Console.Write("Введите число 1 -> ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2 -> ");
int num2 = Convert.ToInt32(Console.ReadLine());

if ((num1*num1 == num2)||(num2*num2 == num1))
{
    Console.Write($" {num1}, {num2} -> да");
}
else
{
    Console.Write($" {num1}, {num2} -> нет");
}



