//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Результат : ");
for (int i =2 ; i <= number1; i=i+2)
{
 Console.Write(+ i + " ");
}
Console.WriteLine();