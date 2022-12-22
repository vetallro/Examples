// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int number = new Random().Next(10,1000000);
//int number = 45;
int result = (number / 10) % 10;

System.Console.WriteLine();
System.Console.WriteLine("Иходное число: " + number);
int pass = number / 100;

if (pass != 0)
{
    while (number >= 999) 
    {
        number = number / 10;
    }
    result = number % 10;
    System.Console.WriteLine("Третья цифра числа: " + result);
}
else
    System.Console.WriteLine("Третьей цифры НЕТ");
System.Console.WriteLine();