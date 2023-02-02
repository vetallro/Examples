// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string message)
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumbers(int m, int n)
{
    int sum = n;
    if (n > m)
    {
        sum += SumNumbers(m, n - 1);
    }
    return sum;
}

int m = InputNumber("Введите число M");
int n = InputNumber("Введите число N");

if (n > m)
    System.Console.WriteLine($" M = {m}; N = {n} -> {SumNumbers(m, n)}");
else
    System.Console.WriteLine($" M = {m}; N = {n} -> {SumNumbers(n, m)}");