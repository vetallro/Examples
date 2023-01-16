// 2)Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InputNumber ( string message )
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int NumberOfDigit ( int num )
{
    int i = 0;
    for ( i = 1; num > 0; i++)
        num /= 10;
    return i - 1;
}

int n = InputNumber("Введите число");
System.Console.WriteLine(" "+ n + " -> " + NumberOfDigit(n));
