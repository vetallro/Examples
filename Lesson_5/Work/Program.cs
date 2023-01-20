//
//------------------------------------------------------------------------
//

// int InputNumber ( string message )
// {
//     Console.Write(message + ": ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int[] CreateArray( int size )
// {
//     int[] createdArray = new int[size];
//     return createdArray;
// } 

// void FillArray( int[] array )
// {
//     Random rnd = new Random();
//     for (var i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(-9, 10);
// }

// string GetArrayInString ( int[] array )
// {
//     return string.Join(", ", array);
// }

// void PrintArray ( int[] array )
// {
//     Console.WriteLine($"[ {GetArrayInString(array)} ]");
// }

// int SummPozitiv ( int[] array )
// {
//     int summ = 0;
//     for (var i = 0; i < array.Length; i++)
//         if (array[i] > 0)
//             summ += array[i];
//     return summ;
// }

// int SummNegative ( int[] array )
// {
//     int summ = 0;
//     for (var i = 0; i < array.Length; i++)
//         if (array[i] < 0)
//             summ += array[i];
//     return summ;
// }

// int size = InputNumber("Введите количество элементов массива");
// //int size = 12;
// Console.WriteLine();
// int[] array = CreateArray(size);
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма позитивных элементов равна: {SummPozitiv(array)}");
// Console.WriteLine($"Сумма позитивных элементов равна: {SummNegative(array)}");

//
//------------------------------------------------------------------------
//

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int InputNumber ( string message )
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray( int size )
{
    int[] createdArray = new int[size];
    return createdArray;
} 

void FillArray( int[] array )
{
    Random rnd = new Random();
    for (var i = 0; i < array.Length; i++)
        array[i] = rnd.Next(900);
}

string GetArrayInString ( int[] array )
{
    return string.Join(", ", array);
}

void PrintArray ( int[] array )
{
    Console.WriteLine($"[ {GetArrayInString(array)} ]");
}

int InRange ( int[] array, int min = 10, int max = 99)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
        if ( array[i] >= min && array[i] <= max )
            count++;
    return count;
}


int size = InputNumber("Введите количество элементов массива");
//int size = 123;
Console.WriteLine();
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество элементов в массив на отрезке от 10 до 99: {InRange(array, 10, 20)}");
Console.WriteLine();

//
//------------------------------------------------------------------------
//

