void FullArray ( int[] collection )
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 99);
    }
}

void PrintArray( int[] collection )
{
    Console.WriteLine("---------");
    int size = collection.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine("---------");
}

void SelectionSort( int[] coll )
{
    for (int i = 0; i < coll.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < coll.Length; j++)
        {
            if ( coll[j] < coll[minPosition] )
                {
                    int temp = coll[j];
                    coll[j] = coll[minPosition];
                    coll[minPosition] = temp;
                }
        }
    }
}

int[] array = new int[20];
FullArray(array);
PrintArray(array);
SelectionSort(array);
PrintArray(array);