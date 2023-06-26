// Вводимое число кратно одновременно 23 и 7


Console.Clear();
Console.Write("Введите число 1 -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
if ((num1%7 == 0)&&(num1%23 == 0))
{
    Console.Write($"Наше число {num1} кратно 7 и 23");
}
else
{
    Console.Write($"Наше число {num1} не кратно 7 и 23");
}

