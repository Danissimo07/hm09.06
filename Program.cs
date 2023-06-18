//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
Console.Write ("введите число А: ");
string number = Console.ReadLine()!;
int num1 = int.Parse(number);
Console.Write ("введите число B: ");
number = Console.ReadLine()!;
int num2 = int.Parse(number);
if (num1 > num2)
{
    Console.WriteLine ("Это число меньше");
}
else
{
    Console.WriteLine ("Это число больше");
}
*/

/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*Console.Write("Ведите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
    max = number2;

if (number3 > max)
    max = number3;
Console.WriteLine(number1 + ", " + number2 + ", " + number3 + "->" + max); */

/*Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным 
(делится ли оно на два без остатка)*/

/*Console.Write("Ведите число:");
int num = Convert.ToInt32(Console.ReadLine());
int del = num % 2;
if (del == 0)
    Console.WriteLine("Число "+ num + " - четное");
else Console.WriteLine("Число "+ num + " - нечетное");*/

 /*Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа 
от 1 до N*/

Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
    {Console.Write(count + ", ");
    count=count+2;}
