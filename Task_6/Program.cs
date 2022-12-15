
Console.Clear();
Console.WriteLine();
Console.Write("Введите число для вывода таблицы умножения: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int Index = 1; Index <=10; Index++) 
{
    int Result = Number * Index;
    Console.Write(Number + " * ");
    Console.Write(Index + " = ");
    Console.Write(Result);
    Console.WriteLine();
}

Console.WriteLine();

// телеграмм преподавателя @slanderc