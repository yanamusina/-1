﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1>number2 && number1>number3)
{
    System.Console.WriteLine("max:" + number1);
}
if (number2>number1 && number2>number3)
{
    System.Console.WriteLine("max:" + number2);
}
if (number3>number1 && number3>number2)
{
    System.Console.WriteLine("max:" + number3);
}