// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string message)
{
    Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Ackermann(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Ackermann(m - 1, 1);
    else
      return Ackermann(m - 1, Ackermann(m, n - 1));
}

System.Console.WriteLine();
int m = InputNumber("Введите число m");
int n = InputNumber("Введите число n");
System.Console.WriteLine();

if ( m  >= 0 && n >= 0)
{
    System.Console.WriteLine($" m = {m}, n = {n} -> A(m,n) = {Ackermann(m,n)}");
    System.Console.WriteLine();
}
else
{
    System.Console.WriteLine($"Числа должны быть неотрицательны!");
    System.Console.WriteLine();
}