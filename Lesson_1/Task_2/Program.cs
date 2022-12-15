// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Clear();
Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if ( Number1 != Number2 )
    if ( Number1 > Number2 )
            Console.Write("Первое число больше второго.");
    else
            Console.Write("Второе число больше первого.");
else
    Console.Write("Числа равны.");
Console.WriteLine();
Console.WriteLine();
