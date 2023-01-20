

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// https://ru.wikihow.com/%D0%BF%D0%B5%D1%80%D0%B5%D0%B2%D0%BE%D0%B4%D0%B8%D1%82%D1%8C-%D0%B8%D0%B7-%D0%B4%D0%B5%D1%81%D1%8F%D1%82%D0%B8%D1%87%D0%BD%D0%BE%D0%B9-%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D1%8B-%D1%81%D1%87%D0%B8%D1%81%D0%BB%D0%B5%D0%BD%D0%B8%D1%8F-%D0%B2-%D0%B4%D0%B2%D0%BE%D0%B8%D1%87%D0%BD%D1%83%D1%8E



// string NewNumber (int num)
// {
//     string binary = string.Empty;
//     for (; num > 0; num/=2)
//     {
//         binary += num % 2;
//     }
//     return binary;
// }

// string FlipOver (string binary)
// {
//     string result = string.Empty;
//     for (var i = binary.Length-1; i >= 0; i--)
//     {
//         result += binary[i];
//     }
//     return result;
// }

// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(NewNumber(num));
// System.Console.WriteLine(FlipOver(NewNumber(num)));



//---------------------------------------------------------------------------


// // Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// string Fibonacci(int n)
// {
//     int one = 0;
//     int two = 1;
//     string answer = one + ", " + two;

//     for(int i = 0; i < n; i++)
//     {
//         int temp = one;
//         one = two;
//         two += temp;
//         answer += ", " + two;
//     }
//     return answer;
// }

// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Fibonacci(n));



//---------------------------------------------------------------------------

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int InputSize(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
    }
}

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int size = InputSize("Введите размер массива: ");

int[] array = new int[size];

FillArray(array);
// int[] array2 = array;    //ссылка array2 на array

System.Console.WriteLine(String.Join(", ", array));
int[] array2 = CopyArray(array);
array[0] = 43;
System.Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine(String.Join(", ", array2));


//---------------------------------------------------------------------------


