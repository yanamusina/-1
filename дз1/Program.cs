﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    System.Console.WriteLine("max:" + number1);
    System.Console.WriteLine("min" + number2);
}
System.Console.WriteLine("max:"+ number2);
System.Console.WriteLine("min:" + number1);