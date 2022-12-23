
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNumber (string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}    

void WriteCube(int numberCube)
{
    int index = 1;
    while (index <= numberCube)
    {
        double result = Math.Pow(index, 3);
        System.Console.Write(result + "  ");
        index++;
    }

}

int number = InputNumber("введите число: ");
WriteCube(number);
System.Console.WriteLine();
System.Console.WriteLine();
