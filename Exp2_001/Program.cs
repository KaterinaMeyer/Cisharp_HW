﻿// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.


Console.Clear();
int num = new Random().Next(100, 1000);
int num1 = num / 100;
int num2 = num % 10;
Console.WriteLine($"число задумали {num}");
Console.WriteLine($"число вывели {num1}{num2}");
