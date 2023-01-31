// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:

// 18 20
// 15 18


int InputNumber(string message)
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateArray2D(int row, int column)
{
    int[,] array = new int[row, column];
    return array;
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

void MultiArray2D(int[,] firstArray, int[,] secondArray, int[,] multiArray)
{
    for (var i = 0; i < multiArray.GetLength(0); i++)
    {
        for (var j = 0; j < multiArray.GetLength(1); j++)
        {
            multiArray[i, j] = 0;
            for (var k = 0; k < firstArray.GetLength(1); k++)
            {
               multiArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
            
        }
    }

}


int rowsFirst = InputNumber("Введите количество строк первого массива");
int columnsFirst = InputNumber("Введите количество столбцов первого массива");
int rowsSecond = InputNumber("Введите количество строк второго массива");
int columnsSecond = InputNumber("Введите количество столбцов второго массива");
System.Console.WriteLine();

if (columnsFirst == rowsSecond)
{
    int[,] arrayFirst = CreateArray2D(rowsFirst, columnsFirst);
    int[,] arraySecond = CreateArray2D(rowsSecond, columnsSecond);
    int[,] arrayMulti = CreateArray2D(rowsFirst, columnsSecond);

    System.Console.WriteLine("Первая матрица.");
    FillArray2D(arrayFirst);
    PrintArray2D(arrayFirst);
    System.Console.WriteLine();

    System.Console.WriteLine("Вторая матрица.");
    FillArray2D(arraySecond);
    PrintArray2D(arraySecond);
    System.Console.WriteLine();

    System.Console.WriteLine("Результирующая матрица.");
    MultiArray2D(arrayFirst, arraySecond, arrayMulti);
    PrintArray2D(arrayMulti);
}
else
{
    System.Console.WriteLine("Количество строк первой матрицы не равно количеству столбцов второй матрицы.");
    System.Console.WriteLine("Умножение невозможно.");
    System.Console.WriteLine();
}

