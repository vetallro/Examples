Console.WriteLine();
Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int ResultMath = Convert.ToInt32(Math.Pow(Number2, 2));

if ( Number1 == ResultMath )
    {
        Console.Write("ДА");
    }
else
    {
        Console.Write("НЕТ");
    }
Console.WriteLine();