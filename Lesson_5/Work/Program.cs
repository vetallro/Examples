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
        array[i] = rnd.Next(-9, 10);
}

string GetArrayInString ( int[] array )
{
    return string.Join(", ", array);
}

void PrintArray ( int[] array )
{
    Console.WriteLine($"[ {GetArrayInString(array)} ]");
}

int SummPozitiv ( int[] array )
{
    int summ = 0;
    for (var i = 0; i < array.Length; i++)
        if (array[i] > 0)
            summ += array[i];
    return summ;
}

int SummNegative ( int[] array )
{
    int summ = 0;
    for (var i = 0; i < array.Length; i++)
        if (array[i] < 0)
            summ += array[i];
    return summ;
}

int size = InputNumber("Введите количество элементов массива");
//int size = 12;
Console.WriteLine();
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма позитивных элементов равна: {SummPozitiv(array)}");
Console.WriteLine($"Сумма позитивных элементов равна: {SummNegative(array)}");
