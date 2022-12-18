int [] array = { 1,5,4,7,5,6,3,7,9,8,4 };
int n = array.Length;

int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}