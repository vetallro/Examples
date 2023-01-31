// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка


int InputNumber(string message)
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray2D(int[,] array2D)
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

void PrintArray2D(int[,] array2D)
{
    for (var i = 0; i < array2D.GetLength(0); i++)
    {
        for (var j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int FindMinInArrayLine(int[,] array)
{
    int min = SumInLine(array, 0);
    int minIndex = 0;
    for (var i = 1; i < array.GetLength(0); i++)
    {
        if (SumInLine(array, i) < min)
        {
            min = SumInLine(array, i);
            minIndex = i;
        }
    }
    return minIndex;
}

int SumInLine(int[,] array, int numberRow)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        sum += array[numberRow, i];
    return sum;
}

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");
System.Console.WriteLine();

int[,] array2D = new int[rows, columns];
FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();

System.Console.WriteLine($"Индекс строки с наименьшей суммой элементов - {FindMinInArrayLine(array2D)}.");
System.Console.WriteLine();