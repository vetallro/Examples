
Console.Clear();

Console.Write("Введите скорость первого человека: ");
int Speed1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите скорость второго человека: ");
int Speed2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


Console.Write("Введите скорость собаки: ");
int SpeedDog = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите расстояние между людьми: ");
int Distance = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int Count = 0;
int ToFriend = 2;
int Time;

while ( Distance > 10 )
    {
    if( ToFriend == 2) 
        {
            Time = Distance/(Speed2 + SpeedDog);
            ToFriend = 1;
        }
    else
        {
            Time = Distance/(Speed1 + SpeedDog);
            ToFriend = 2;
        }
    Count = Count + 1;
    Distance = Distance - (Speed1 + Speed2) * Time;
    }

Console.WriteLine("Собака успеет пробежать " + Count + " раз.");