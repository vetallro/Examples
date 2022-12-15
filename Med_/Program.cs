Console.Clear();
Console.Write("Введите Имя: ");
string Name = Console.ReadLine();
Console.WriteLine();

Console.Write("Введите Фамилию: ");
string Lastname = Console.ReadLine();
Console.WriteLine();

Console.Write("Введите возраст: ");
int Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите вес: ");
int Weight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if ( Age < 30) 
{
    if (Weight >= 50 && Weight <= 120 )
    {
        Console.Write("Пациент: " + Lastname);Console.Write(" " + Name);Console.WriteLine(" - Все хорошо" );
    }
    else
    {
        Console.Write("Пациент: " + Lastname);Console.Write(" " + Name);Console.WriteLine(" - Заняться собой" );
    }
}

else if ( Age >= 30 && Age <= 40 )
{
    if (Weight >= 50 && Weight <= 120 )
    {
        Console.Write("Пациент: " + Lastname);Console.Write(" " + Name);Console.WriteLine(" - Пока все хорошо" );
    }
    else
    {
        Console.Write("Пациент: " + Lastname);Console.Write(" " + Name);Console.WriteLine(" - Пора заняться собой" );
    }
}

else if ( Age >= 40 )
{
    if (Weight >= 50 && Weight <= 120 )
    {
        Console.Write("Пациент: " + Lastname);Console.Write(" " + Name);Console.WriteLine(" - Все хорошо, но заняться собой" );
    }
    else
    {
        Console.Write("Пациент: " + Lastname);Console.Write(" " + Name);Console.WriteLine(" - Пора показаться врачу" );
    }
}

Console.WriteLine();
Console.WriteLine();