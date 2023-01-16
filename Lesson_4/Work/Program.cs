//
//------------------------------------------------------------------------
//

System.Console.WriteLine("Введите пятизначное число");
int arrayInOneNumber = Convert.ToInt32(Console.ReadLine());
int [] array = new int [5];
if (arrayInOneNumber/10000 == 0 || arrayInOneNumber/10000 > 9)
    {
        Console.WriteLine("Вы ввели число, которое не соответствует условиям");
    return;
    }

int degree = 4;
 for (int i = 0; i < array.Length; i++)
     {
        array [i] = arrayInOneNumber/(int)Math.Pow(10, degree);
        arrayInOneNumber=arrayInOneNumber%(int)Math.Pow(10, degree);
        degree = degree - 1; 
     }
if (array[0] == array [4] && array[1] == array [3])
    {
        System.Console.WriteLine("да, число является палиндромом");
    }
else
    {
        System.Console.WriteLine("нет, число не является палиндромом");
    }



int CountDigits(int inmputNumber)
{
    int countDigit = 0;
    
    for (; inmputNumber > 0; countDigit++)
        inmputNumber /= 10;

    return countDigit;
}


bool Palindrome(int inputNumber, int countNumbers)
{
    for (;countNumbers > 0;)
    {
        // 4321 

        int degreeOfTen = (int)(Math.Pow(10, countNumbers - 1));
        //1000
        int fistDigit = inputNumber / degreeOfTen;
        // 4321 / 1000 = 4
        int lastDigit = inputNumber % 10;
        // 4321 % 10 = 1
        
        if (fistDigit != lastDigit)
            return false;    

        inputNumber -= fistDigit * degreeOfTen;
        // inmput = 4321 - ( 4 * 1000)
        // 4321 - 4000 = 321
        inputNumber /= 10;
        // inputNumber = 321 / 10
        //32
        countNumbers -= 2;
        //2

    }

    return true;
}

//
//------------------------------------------------------------------------
//

(double x, double y, double z) GetPointFromConsole(string message)
{
    Console.WriteLine(message);
    Console.WriteLine();

    double x = GetNumberFromConsole("x:");
    double y = GetNumberFromConsole("y:");
    double z = GetNumberFromConsole("z:");

    return (x , y, z);
}

int GetNumberFromConsole(string message)
{
    System.Console.WriteLine(message);
    return Int32.Parse(Console.ReadLine());
}

(double x, double y, double z) point1 = GetPointFromConsole("Введите точку A:");
(double x, double y, double z) point2 = GetPointFromConsole("Введите точку B:");

double answer = Math.Round(Math.Sqrt(Math.Pow(point2.x - point1.x,2) + 
    Math.Pow(point2.y-point1.y,2)+Math.Pow(point2.z - point1.z,2)),2);

Console.WriteLine("Расстояние между двумя точками в 3D пространстве: " + answer);

//
//------------------------------------------------------------------------
//
