
Console.WriteLine();
Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int LastNumber = Number - Number/10*10;
int LastNumber2 = Number % 10;

Console.WriteLine(LastNumber);
Console.WriteLine(LastNumber2);

// телеграмм преподавателя @slanderc
