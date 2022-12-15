
Console.WriteLine();
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int AlterNumber = - (Number);
int i = AlterNumber;
while (i <= Number)
{
    Console.Write(i + " ");
    i++;
}
Console.WriteLine();
Console.WriteLine();  