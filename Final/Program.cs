// Контрольная работа 

// ["hello", "2", "world", ":-)" ] => ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] => ["-2"]
// [Russia, "Denmark", "Kazan"] => []

void RewriteArray(string[] array, string[] newArray, int numb)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numb)
        {
            Array.Copy(array, i, newArray, count, 1 );
            count++;
        }
    }
}

void PrintArray ( string [] array )
{
    for (var i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

// string[] source = { "hello", "2", "world", ":-)" };
 string[] source = {"1234", "1567", "-2", "computer science"};
// string[] source = {Russia, "Denmark", "Kazan"};
int numb = 3;
string[] newSource = new string[source.Length];

RewriteArray(source, newSource, numb);
PrintArray(newSource);
