// Сортировка массива 


// void FullArray ( int[] collection )
// {
//     int length = collection.Length;
//     for (int i = 0; i < length; i++)
//     {
//         collection[i] = new Random().Next(1, 99);
//     }
// }

// void PrintArray( int[] collection )
// {
//     Console.WriteLine();
//     Console.WriteLine("---------");
//     int size = collection.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(collection[i] + " ");
//     }
//     Console.WriteLine();
//     Console.WriteLine("---------");
// }

// void SelectionSort( int[] coll )
// {
//     for (int i = 0; i < coll.Length - 1; i++)
//     {
//         //int minPosition = i;
//         for (int j = i + 1; j < coll.Length; j++)
//         {
//             if ( coll[j] < coll[i] )
//                 {
//                     int temp = coll[j];
//                     coll[j] = coll[i];
//                     coll[i] = temp;
//                 }
//         }
//     }
// }

// int[] array = new int[20];
// FullArray(array);
// PrintArray(array);
// SelectionSort(array);
// PrintArray(array);



//
// Зменить символы в строке 
//


string Replace( string text, char oldValue, char newValue )
{
    string result = String.Empty;
    int length = text.Length;

    for (var i = 0; i < length; i++)
    {
        if ( text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}


string oldText = "Количество мест по спецпредложению ограничено, тариф может быть недоступен на рейсы или даты высокого спроса. Рекомендуем обращать внимание на значок купона, обозначающий скидку, у цены по интересующему Вас направлению.";
string newText = Replace(oldText, ' ', '|');
newText = Replace(newText, 'е', 'Е');
newText = Replace(newText, 'а', 'А');

Console.WriteLine(newText);