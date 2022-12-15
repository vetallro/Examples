Console.Clear();
Console.Write("Введите число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if ( Number1 % 2 == 0 )
    Console.Write("Число четное.");
else
    Console.Write("Число нечетное.");

Console.WriteLine();
Console.WriteLine();