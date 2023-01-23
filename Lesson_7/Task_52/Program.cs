// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
//
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int InputNumber(string message)
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray2D(double[,] array2D)
{
    Random rnd = new Random();
    for (var i = 0; i < array2D.GetLength(0); i++)
    {
        for (var j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(0, 10);
        }
    }

}

void PrintArray2D(double[,] array2D)
{
    for (var i = 0; i < array2D.GetLength(0); i++)
    {
        for (var j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + "   ");
        }
        System.Console.WriteLine();
    }
}

void AverageInArrayAndPrint(double[,] array2D)
{
    for (var i = 0; i < array2D.GetLength(0); i++)
    {
        double sum = 0;
        for (var j = 0; j < array2D.GetLength(1); j++)
        {
            sum += array2D[i, j];
        }
        double average = sum / array2D.GetLength(1);
        System.Console.WriteLine("Среднее по " + (i + 1) + " строке равно - " + Math.Round(average, 1));
    }
}

System.Console.WriteLine();
int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");
double[,] arrayNew = new double[rows, columns];

FillArray2D(arrayNew);
System.Console.WriteLine();
PrintArray2D(arrayNew);
System.Console.WriteLine();
AverageInArrayAndPrint(arrayNew);
System.Console.WriteLine();
