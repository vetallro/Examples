
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int Result = Number * Number;
int ResultMath = Convert.ToInt32(Math.Pow(Number,2));

Console.Write("Ответ: ");
Console.WriteLine(Result);
Console.Write("И еще ответ: ");
Console.WriteLine(ResultMath);

System.Console.WriteLine();


