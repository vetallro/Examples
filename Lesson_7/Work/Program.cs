// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+J. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
//
//--------------------------------------------------------------------------------
//


// void FillArray2D ( int [,] array2D )
// {
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[ i, j ] = i + j;
//         }
//     }

// }

// void PrintArray2D ( int [,] array2D )
// {
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[ i, j ] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = 3;
// int columns = 4;

// int [,] array2D = new int [ rows, columns ];                     
// FillArray2D(array2D);
// PrintArray2D(array2D);


//
//--------------------------------------------------------------------------------
//
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
// Новый массив будет выглядеть вот так:
//
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
//


// int InputNumber ( string message )
// {
//     Console.Write(message + ": ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// void FillArray2D ( int [,] array2D )
// {
//     Random rnd = new Random();
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[ i, j ] = rnd.Next(0, 10);
//         }
//     }

// }

// void PrintArray2D ( int [,] array2D )
// {
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[ i, j ] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void SetCube ( int [,] array2D )
// {
//       for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array2D[i, j] = array2D[i, j] * array2D [i, j];
//             }
//         }
//     }
// }


// int rows = InputNumber("Введите количество строк массива");
// int columns = InputNumber("Введите количество столбцов массива");

// int [,] arrayNew = new int [ rows, columns ];

// PrintArray2D (arrayNew);
// FillArray2D (arrayNew);
// System.Console.WriteLine();
// PrintArray2D (arrayNew);
// System.Console.WriteLine();
// SetCube(arrayNew);
// PrintArray2D(arrayNew);


//
//--------------------------------------------------------------------------------
//

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int InputNumber ( string message )
// {
//     Console.Write(message + ": ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// void FillArray2D ( int [,] array2D )
// {
//     Random rnd = new Random();
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[ i, j ] = rnd.Next(0, 10);
//         }
//     }

// }

// void PrintArray2D ( int [,] array2D )
// {
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[ i, j ] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int DiagonalSum ( int [,] array2D )
// {
//     int sum = 0;
//       for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                sum += array2D[i, j];
//             }
//         }
//     }
//     return sum;
// }

// int rows = InputNumber("Введите количество строк массива");
// int columns = InputNumber("Введите количество столбцов массива");

// int [,] arrayNew = new int [ rows, columns ];

// PrintArray2D (arrayNew);
// FillArray2D (arrayNew);
// System.Console.WriteLine();
// PrintArray2D (arrayNew);
// System.Console.WriteLine();
// System.Console.WriteLine("Сумма элементов диагонали равна: " + DiagonalSum(arrayNew)); 


//
//--------------------------------------------------------------------------------
//


// Дан двумерный массив. Поменять местами:
// а) элементы, расположенные в правом верхнем и левом нижнем углах;
// б) элементы, расположенные в правом нижнем и левом верхнем углах.


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

void CrossNumbersRightUpLeftDown ( int [,] array2D )
{
    int temp = array2D [0, array2D.GetLength(1)-1];
    array2D [0, array2D.GetLength(1)-1] = array2D[array2D.GetLength(0)-1, 0];
    array2D [array2D.GetLength(0)-1, 0] = temp;
}

void CrossNumbersRightDownLeftUp ( int [,] array2D )
{
    int temp = array2D[array2D.GetLength(0)-1, array2D.GetLength(1)-1];
    array2D[array2D.GetLength(0)-1, array2D.GetLength(1)-1] = array2D[0, 0];
    array2D[0, 0] = temp;
}

int rows = 5;
int columns = 5;

int [,] arrayNew = new int [ rows, columns ];

PrintArray2D (arrayNew);
FillArray2D (arrayNew);
System.Console.WriteLine();
PrintArray2D (arrayNew);
CrossNumbersRightUpLeftDown(arrayNew);
CrossNumbersRightDownLeftUp(arrayNew);

System.Console.WriteLine();
PrintArray2D (arrayNew);
System.Console.WriteLine();

//
//--------------------------------------------------------------------------------
//


