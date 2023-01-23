// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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
            System.Console.Write(array2D[i, j] + "   ");
        }
        System.Console.WriteLine();
    }
}


int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");

int[,] arrayNew = new int[rows, columns];

PrintArray2D(arrayNew);
FillArray2D(arrayNew);
System.Console.WriteLine();
PrintArray2D(arrayNew);
System.Console.WriteLine();

int numberInRow = InputNumber("Введите номер строки");
int numberInColumns = InputNumber("Введите номер столбца");

if (numberInRow - 1 > arrayNew.GetLength(0) || numberInColumns - 1 > arrayNew.GetLength(1))
{
    System.Console.WriteLine("такого числа в массиве нет");
}
else
{
    System.Console.WriteLine("Значение ячейки: " + arrayNew[numberInRow - 1, numberInColumns - 1]);
}
