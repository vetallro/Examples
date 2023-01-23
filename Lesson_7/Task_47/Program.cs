// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


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
            array2D[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
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


int rows = InputNumber("Введите количество строк массива");           // 3
int columns = InputNumber("Введите количество столбцов массива");     // 4

double[,] arrayNew = new double[rows, columns];

// Random rnd = new Random();
// double temp = new Random().Next;

PrintArray2D(arrayNew);
FillArray2D(arrayNew);
System.Console.WriteLine();
PrintArray2D(arrayNew);
System.Console.WriteLine();

