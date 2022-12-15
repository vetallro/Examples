Console.Clear();
Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите третье число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int Max = Number1;

if ( Number2 > Max )
    Max = Number2;
if (Number3 > Max )
    Max = Number3;

Console.Write("Максимальное число: " + Max);
Console.WriteLine();
Console.WriteLine();