// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int number = new Random().Next(100,1000);
//int number = 924;
int result = (number / 10) % 10;

System.Console.WriteLine();
System.Console.WriteLine("Иходное число: " + number);
System.Console.WriteLine("Вторая чифра числа: " + result);
System.Console.WriteLine();
