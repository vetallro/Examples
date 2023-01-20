// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double InputNumber ( string message )
{
    Console.Write(message + ": ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

// string GetArrayInString ( double[] array )
// {
//     return string.Join(", ", array);
// }

// void PrintArray ( double[] array )
// {
//     Console.WriteLine($"[ {GetArrayInString(array)} ]");
// }

bool CheckLine (double b1, double k1, double b2, double k2)
{
   if ( k1 == k2 && b1 != b2 )
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Прямые парралельны - не пересекаются.");
        System.Console.WriteLine();
        return false;
    }

    if ( k1 == k2 && b1 == b2 )
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Прямые имеют множество точек пересечения.");
        System.Console.WriteLine();
        return false;
    } 
    return true;
}

(double x, double y) CrossPoint (double b1, double k1, double b2, double k2)
{
    double x = ((b2 - b1) / (k1 - k2));
    double y = (k2 *((b2 - b1) / (k1 - k2))) + b2;
    return (x, y);
}

Console.WriteLine("Ищем пересечение двух прямых:");
Console.WriteLine("Первая прямая y = k1 * x + b1");
Console.WriteLine("Вторая прямая y = k2 * x + b2");
Console.WriteLine("Необходимо внести значения для расчета пересечения.");

double b1 = InputNumber("Введите b1");
double k1 = InputNumber("Введите k1");
double b2 = InputNumber("Введите b2");
double k2 = InputNumber("Введите k2");

if (CheckLine( b1, k1, b2, k2 )) Console.WriteLine($"Координаты точки пересечения: {CrossPoint( b1, k1, b2, k2 )}");

//double[] cross = CrossPoint ( b1, k1, b2, k2 );
//PrintArray (cross);
//System.Console.WriteLine(cross[0]);

// вычисления формулы:
// y = k1 * x + b1
// y = k2 * x + b2

// y - y = (k1 * x + b1) - (k2 * x + b2)
// 0 = k1 * x + b1 - k2 * x - b2
// b2 - b1 = k1*x - k2*x
// (b2 - b1) = (k1 - k2)*x

// x = ((b2 - b1) / (k1 - k2))
// y = (k2 *((b2 - b1) / (k1 - k2))) + b2
