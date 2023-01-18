// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
        array[i] = rnd.Next(100, 1000);
}

string GetArrayInString ( int[] array )
{
    return string.Join(", ", array);
}

void PrintArray ( int[] array )
{
    Console.WriteLine($"[ {GetArrayInString(array)} ]");
}

int CountOdd ( int[] array )
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

int CountEven ( int[] array )
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0)
            count++;
    return count;
}

int size = InputNumber("Введите количество элементов массива");
//int size = 12;
Console.WriteLine();
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно: {CountOdd(array)}");
Console.WriteLine($"Количество нечетных чисел в массиве равно: {CountEven(array)}");
