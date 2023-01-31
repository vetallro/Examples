// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// // Например, задан массив:

// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

// // В итоге получается вот такой массив:

// // 8 4 2 4
// // 5 9 2 3
// // 1 4 7 2


// int InputNumber(string message)
// {
//     Console.Write(message + ": ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// void FillArray2D(double[,] array2D)
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

// void PrintArray2D(double[,] array2D)
// {
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (var j = 0; j < array2D.GetLength(1); j++)
//         {
//             System.Console.Write(array2D[i, j] + "   ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void CrossFirstToLast(double[,] array2D)
// {
//     double temp = 0;
//     for (var i = 0; i < array2D.GetLength(0); i++)
//     {
//         temp = array2D[0, i];
//         array2D[0, i] = array2D[array2D.GetLength(1) - 1, i];
//         array2D[array2D.GetLength(1) - 1, i] = temp;
//     }
// }

// System.Console.WriteLine();
// int rows = InputNumber("Введите количество строк массива");
// int columns = InputNumber("Введите количество столбцов массива");
// double[,] arrayNew = new double[rows, columns];

// FillArray2D(arrayNew);
// System.Console.WriteLine();
// PrintArray2D(arrayNew);
// System.Console.WriteLine();
// CrossFirstToLast(arrayNew);
// PrintArray2D(arrayNew);
// System.Console.WriteLine();


// //------------------------------------------------------------------------------------------
// // транспонирование массива 


// void TranspArray(int[,] array)
// {
//     for (int i = 1, j = 1; i < array.GetLength(0); i++, j++)
//     {
//         for (int k = i; k > 0; k--)
//         {
//             int temp = array[i - k, j];
//             array[i - k, j] = array[i, j - k];
//             array[i, j - k] = temp;
//         }
//     }
// }

// int InputNumber(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] FillArray2D(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];

//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToInt32(rnd.Next(0, 10));
//         }
//     }
//     return array;
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = InputNumber("Введите количество строк массива: ");
// int columns = InputNumber("Введите количество столбцов массива: ");
// System.Console.WriteLine();

// int[,] array2D = FillArray2D(rows, columns);
// PrintArray2D(array2D);
// System.Console.WriteLine();
// TranspArray(array2D);
// PrintArray2D(array2D);
// System.Console.WriteLine();


// void TransArray(int[,] array)
// {
//     for(int i = 1, j = 1; i < array.GetLength(0); i++, j++)
//     {
//         for(int k = i; k > 0; k--)
//         {
//             int temp = array[i - k, j];
//             array[i - k, j] = array[i, j - k];
//             array[i, j - k] = temp;
//         }
//     }
// }


// //-----------------------------------------------------------------------------------------
// // проверка количества и пересчет в массиве


// int InputNumber(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] FillArray2D(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];

//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToInt32(rnd.Next(0, 10));
//         }
//     }
//     return array;
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] Array2DToArray(int[,] array2D)
// {
//     int rows = array2D.GetLength(0);
//     int columns = array2D.GetLength(1);
//     int[] array = new int[rows * columns];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array2D[i / columns, i % columns];
//         // System.Console.Write(i + ", ");
//         // System.Console.Write(columns + ", ");
//         // System.Console.Write(i/columns + ", ");
//         // System.Console.WriteLine(i%columns);
//     }

//     return array;
// }

// void SortArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[i])
//             {
//                 int temp = array[i];
//                 array[i] = array[j];
//                 array[j] = temp;
//             }
//         }
//     }
// }

// void CountElementsInArray(int[] array)
// {
//     int count = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1)
//         {
//             System.Console.WriteLine($"{array[i]} в массиве {count} раз.");
//             break;
//         }

//         if (array[i] == array[i + 1])
//         {
//             count++;
//         }
//         else
//         {
//             System.Console.WriteLine($"{array[i]} в массиве {count} раз.");
//             count = 1;
//         }
//     }
// }

// int rows = InputNumber("Введите количество строк массива: ");
// int columns = InputNumber("Введите количество столбцов массива: ");
// System.Console.WriteLine();


// int[,] array2D = new int [rows, columns];
// FillArray2D(array2D);
// PrintArray2D(array2D);
// System.Console.WriteLine();

// int[] newArray = Array2DToArray(array2D);
// System.Console.WriteLine(String.Join(", ", newArray));
// SortArray(newArray);
// System.Console.WriteLine(String.Join(", ", newArray));
// System.Console.WriteLine();
// CountElementsInArray(newArray);
// System.Console.WriteLine();