// 5) Заполнить массив случайными числами (количество элементов с клавиатуры)
// Заполнение в методах , вывод массиа , даже если через string join , то в методе (просто вернуть строку)
//


int InputNumber ( string message )
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray ( int[] collection, int min, int max )
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
        collection[i] = new Random().Next(min, max + 1);
}

void PrintArray ( int[] array )
{
    string str = string.Join(",", array);
    Console.WriteLine("[" + str + "]");
}

Console.WriteLine();
int n = InputNumber("Введите количество элементов массива");
int min = InputNumber("Введите минимальный элемент массива");
int max = InputNumber("Введите максимальный элемент массива");

if (min > max)
{
    Console.WriteLine("Минимальное значение массива не может быть больше максимального!");
    return;
}

int[] arr = new int[n];

FillArray(arr, min, max);
Console.WriteLine();
PrintArray(arr);