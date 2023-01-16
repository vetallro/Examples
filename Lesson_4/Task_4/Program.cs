// 4)Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int InputNumber ( string message )
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray ( int[] collection )
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
        collection[i] = new Random().Next(0, 2);
}

int n = InputNumber("Введите количество элементов массива");
int[] arr = new int[n];

FillArray(arr);
string str = string.Join(",", arr);
Console.WriteLine("[" + str + "]");