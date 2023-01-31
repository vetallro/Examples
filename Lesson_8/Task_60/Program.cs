// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNumber(string message)
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,,] CreateArray3D(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    return array;
}

void FillArray3D(int[,,] array3D)
{
    Random rnd = new Random();
    for (var i = 0; i < array3D.GetLength(0); i++)
    {
        for (var j = 0; j < array3D.GetLength(1); j++)
        {
            for (var k = 0; k < array3D.GetLength(2); k++)
            {
                while (CheckNumberInArray(array3D, array3D[i, j, k]))
                {
                    array3D[i, j, k] = rnd.Next(0, 100);
                }
            }
        }
    }
}

void PrintArray3D(int[,,] array3D)
{
    for (var i = 0; i < array3D.GetLength(0); i++)
    {
        for (var j = 0; j < array3D.GetLength(1); j++)
        {
            for (var k = 0; k < array3D.GetLength(2); k++)
            {
                System.Console.Write($"{array3D[i, j, k]} ({i},{j},{k})   ");
            }
            System.Console.WriteLine();
        }
    }
}

bool CheckNumberInArray(int[,,] array3D, int number)
{
    int count = 0;
    for (var i = 0; i < array3D.GetLength(0); i++)
    {
        for (var j = 0; j < array3D.GetLength(1); j++)
        {
            for (var k = 0; k < array3D.GetLength(2); k++)
            {
                if (array3D[i, j, k] == number)
                {
                    count++;
                    if (count > 1)
                    {
                        return true;
                    }
                }
            }
        }
    }
    return false;
}


int x = InputNumber("Введите количество X массива");
int y = InputNumber("Введите количество Y массива");
int z = InputNumber("Введите количество Z массива");
System.Console.WriteLine();

int[,,] array = CreateArray3D(x, y, z);

System.Console.WriteLine("Вывод массива.");
System.Console.WriteLine();
FillArray3D(array);
PrintArray3D(array);
System.Console.WriteLine();
