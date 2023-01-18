// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
        array[i] = rnd.Next(-10, 11);
}

string GetArrayInString ( int[] array )
{
    return string.Join(", ", array);
}

void PrintArray ( int[] array )
{
    Console.WriteLine($"[ {GetArrayInString(array)} ]");
}

int Count ( int[] array )
{
    int summ = 0;
    for (var i = 1; i < array.Length; i+=2)
        summ+=array[i];
    return summ;
}

int size = InputNumber("Введите количество элементов массива");
//int size = 12;
Console.WriteLine();
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива на нечетных местах: {Count(array)}");
Console.WriteLine();