Console.Clear();
Console.Write("Введите число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for ( int Index = 2; Index <= Number1; Index = Index + 2 )
    Console.Write(Index + ", ");

Console.WriteLine();
Console.WriteLine();