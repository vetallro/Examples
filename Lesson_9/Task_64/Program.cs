// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int InputNumber(string message)
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void Countdown(int i)
{
    System.Console.Write(i);
    if (i <= 1)
    {
        return;
    }
    System.Console.Write(", ");
    Countdown(i - 1);
}

int i = InputNumber("Введите число N");
System.Console.Write($" N = {i} -> \"");
Countdown(i);
System.Console.Write($"\"");
