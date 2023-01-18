// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


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
        array[i] = rnd.Next(-50, 51);
}

string GetArrayInString ( int[] array )
{
    return string.Join(", ", array);
}

void PrintArray ( int[] array )
{
    Console.WriteLine($"[ {GetArrayInString(array)} ]");
}

int Max ( int[] array )
{
    int max = array[0];
    for (var i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}


int Min ( int[] array )
{
    int min = array[0];
    for (var i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

int size = InputNumber("Введите количество элементов массива");
//int size = 12;
Console.WriteLine();
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значением массива: {Max(array) - Min(array)}");
Console.WriteLine();