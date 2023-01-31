// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNumber(string message)
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray2D ( int [,] array2D )
{
    Random rnd = new Random();
    for (var i = 0; i < array2D.GetLength(0); i++)
    {
        for (var j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[ i, j ] = rnd.Next(0, 10);
        }
    }

}

void PrintArray2D ( int [,] array2D )
{
    for (var i = 0; i < array2D.GetLength(0); i++)
    {
        for (var j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[ i, j ] + " ");
        }
        System.Console.WriteLine();
    }
}

void BoobleSortInLineArray (int [,] array, int numberColumn)
{
    for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[ numberColumn ,j] < array[numberColumn ,i])
                {
                    int temp = array[numberColumn,i];
                    array[numberColumn,i] = array[numberColumn,j];
                    array[numberColumn,j] = temp;
                }
            }
        }
}


void SortUpArrayInLine(int[,] array)
{
    for (var k = 0; k < array.GetLength(0); k++)
    {
        BoobleSortInLineArray(array, k);
    }
    
}

void SortDownArrayInLine(int[,] array)
{
    for (var k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k,j] > array[k,i])
                {
                    int temp = array[k,i];
                    array[k,i] = array[k,j];
                    array[k,j] = temp;
                }
            }
        }
    }
    
}

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");
System.Console.WriteLine();

int [,] array2D = new int [ rows, columns ];
FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();

SortDownArrayInLine(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();

SortUpArrayInLine(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();
