
Console.WriteLine();
Console.Write("Введите имя пользователя: ");

string userName = Console.ReadLine();
Console.WriteLine();

if (userName.ToLower() == "маша")
{
    Console.WriteLine("УРА, это Маша!!!");
}
else
{
    Console.WriteLine("Привет, " + userName + "!");
}
Console.WriteLine();

