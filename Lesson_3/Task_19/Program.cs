// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.Clear();
System.Console.WriteLine();

int InputNumber (string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}    

string CheckNumber (int num)
{
    if (( num / 10000 == num % 10 ) && (( num / 1000 ) % 10) == ((num / 10 ) % 10))
    {
        return "Да, число - палиндром.";
    }
    else
    {
        return "Нет, число - не палиндром.";
    }
}


bool set = true;
int number = InputNumber("Введите число: ");

do
{
    if ((number / 10000 <= 0) || (number /10000 > 10) )
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Это не пятизначное число!");
        System.Console.WriteLine();
        number = InputNumber("Введите число: ");
    }
    else
    {
        set = false;
        System.Console.WriteLine();
        System.Console.WriteLine(CheckNumber(number));
        System.Console.WriteLine();
        Console.Beep(1000, 500);
    }
} 
while (set);
