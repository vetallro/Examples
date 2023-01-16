// 1)Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int InputNumber ( string message )
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumFromFirstToNumber ( int num )
{
    int sum = 0;
    for (var i = 1; i <= num; i++)
        sum += i;
    return sum;
}

int n = InputNumber("Введите число");
System.Console.WriteLine("Сумма чисел от 1 до " + n + " равна: " + SumFromFirstToNumber(n));
