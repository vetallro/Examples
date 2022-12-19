void FullArray ( int[] collection )
{
    int length = collection.Length;
    int index = 0;

    while ( index < length )
    {
        collection[index] = new Random().Next(1, 5);
        index++;
    }

}

void PrintArray( int[] collection )
{
    int size = collection.Length;
    int pozition = 0;

    while ( pozition < size )
    { 
        Console.Write(collection[ pozition ] + " ");
        pozition++;
    }

}

int IndexOf( int[] collect, int find )
{
    int i = collect.Length;
    int index = 0;
    int position = -1;

    while ( index < i )
    {
        if( collect[index] == find )
        {
            position = index;
            break;
        }
      index++;
    }
    return position;      
}

int[] array = new int[20];
FullArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine( "Первое вхождение " + pos );