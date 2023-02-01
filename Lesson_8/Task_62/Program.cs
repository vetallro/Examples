// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int InputNumber(string message)
// {
//     Console.Write(message + ": ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int[,] CreateArray2D(int row, int column)
// {
//     int[,] array = new int[row, column];
//     return array;
// }

// void FillArray2D(int[,] array2D)
// {
//     Random rnd = new Random();
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = rnd.Next(0, 10);
//         }
//     }

// }

// void PrintArray2D(int[,] array2D)
// {
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }



const int n = 11;

int [,] a = GetSpire(n);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i,j] + " ");
    }
    Console.WriteLine();
}


int[,] GetSpire(int n)
{
    var result = new int[n, n];
    for (int currentChar = 1, padding = 0; padding < n/2; padding++)
    {
        for (int j = padding; j < n - padding; j++)
            result[padding, j] = currentChar;
        for (int j = padding; j < n - padding; j++)
            result[n - padding - 1, j] = currentChar;
        for (int i = padding + 2; i < n - padding - 1; i++)
            result[i, padding] = currentChar;
        for (int i = padding + 1; i < n - padding - 1; i++)
            result[i, n - padding - 1] = currentChar;
        currentChar = 1 - currentChar;
        result[padding + 1, padding] = currentChar;
    }
    if (n%2 != 0 && result[0, 0] == 1)
        result[n/2, n/2] = 1;
    return result;
}











// int rows = InputNumber("Введите количество строк массива");
// int columns = InputNumber("Введите количество столбцов массива");
// System.Console.WriteLine();

// int[,] array = CreateArray2D(rows, columns);

// System.Console.WriteLine();
// PrintArray2D(array);
// System.Console.WriteLine();
// FillArray2D(array);
// PrintArray2D(array);
// System.Console.WriteLine();
