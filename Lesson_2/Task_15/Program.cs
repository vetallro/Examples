
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (( Number < 1 ) || ( Number > 7 ))
{
    Console.WriteLine("Введен не день недели!"); 
}
else if (( Number == 6 ) || ( Number == 7 ))
{
    Console.WriteLine("Да");
}
else
{
      Console.WriteLine("Нет");
}
Console.WriteLine();