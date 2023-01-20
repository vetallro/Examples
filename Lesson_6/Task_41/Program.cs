// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


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

void FillArrayByUser ( int[] array )
{
        int number = 0;
        for (var i = 0; i < array.Length; i++)
        {
            System.Console.Write($"Введите {i+1} элемент массива: ");
            number = Convert.ToInt32(Console.ReadLine());
            array[i] = number;
        }
       
}

string GetArrayInString ( int[] array )
{
    return string.Join(", ", array);
}

void PrintArray ( int[] array )
{
    Console.WriteLine();
    Console.WriteLine($"[ {GetArrayInString(array)} ]");
    Console.WriteLine();
}

int CountPositiveNumbers ( int[] array )
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count++;
    return count;
}


int size = InputNumber("Введите количество элементов массива");
int[] array = CreateArray(size);

FillArrayByUser(array);
PrintArray(array);

Console.WriteLine($"Количество элементов больше 0 равно: {CountPositiveNumbers(array)}");
System.Console.WriteLine();
