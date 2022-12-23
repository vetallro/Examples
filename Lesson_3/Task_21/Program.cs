
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double InputNumber (string message)
{
    System.Console.Write(message);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}    

double FindLength (double x1, double y1, double x2, double y2)
{
    double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return result;

}

System.Console.WriteLine();
System.Console.WriteLine("Введите координаты ПЕРВОЙ точки отрезка:");
double x1 = InputNumber("Координата X: ");
double y1 = InputNumber("Координата Y: ");

System.Console.WriteLine();
System.Console.WriteLine("Введите координаты ВТОРОЙ точки отрезка:");
double x2 = InputNumber("Координата X: ");
double y2 = InputNumber("Координата Y: ");

System.Console.WriteLine();
System.Console.WriteLine();
double res = FindLength(x1, y1, x2, y2);
System.Console.WriteLine("Длина отрезка: " + res);
