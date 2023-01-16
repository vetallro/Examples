// 3)Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120



int InputNumber ( string message )
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int MultiFromOneToNumber( int numb )
{
    int mult = 1;
    for (int i = 1; i <= numb; i++)
        mult *= i;
    return mult;
}

int n = InputNumber("Введите число");
System.Console.WriteLine( "Ответ: " + n + " -> " + MultiFromOneToNumber(n));