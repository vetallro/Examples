
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
//
//======================================================================================



// System.Console.Clear();
// System.Console.WriteLine();

// int InputNumber(string message)
// {
//     System.Console.Write(message);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// string CheckNubmer(int number)
// {
//     if (number == 1)
//         {
//         string onswer = "1. X от 0 до бесконечности. Y от 0 до бесконечности.";
//         return onswer;
//         }
//     if (number == 2)
//         {
//         string onswer = "2. X от 0 до бесконечности. Y от 0 до бесконечности.";
//         return onswer;
//         }
//     if (number == 3)
//         {
//         string onswer = "3. X от 0 до бесконечности. Y от 0 до бесконечности.";
//         return onswer;
//         }
//     if (number == 4)
//         {
//         string onswer = "4. X от 0 до бесконечности. Y от 0 до бесконечности.";
//         return onswer;
//         }
//     return "это не четверть";
// }

// int numb = InputNumber("Введите номер четверти: ");

// while (numb < 1 || numb > 4)
// {
//     System.Console.WriteLine();
//     System.Console.WriteLine("Это не номер четверти!");
//     System.Console.WriteLine();
//     numb = InputNumber("Введите номер четверти: ");
// }

// System.Console.WriteLine();
// System.Console.WriteLine("OK!");
// System.Console.WriteLine();
// System.Console.WriteLine(CheckNubmer(numb));
// System.Console.WriteLine();






//======================================================================================
//
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
//

// System.Console.Clear();
// System.Console.WriteLine();

// int InputNumber(string message)
// {
//     System.Console.Write(message);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// double SquareNumber ( int number )
// {
//     double result = Math.Pow(number, 2);
//     return result;
// }

// int numb = InputNumber("Введите число: ");

// for (int i = 1; i <= numb; i++)
// {
//     System.Console.Write(SquareNumber(i) + "  ");
// }
// System.Console.WriteLine();


//======================================================================================

// Далее необязательные задания

// В один из жарких летних дней Петя и его друг Вася решили купить арбуз. Они выбрали самый большой и самый спелый, 
// на их взгляд. После недолгой процедуры взвешивания весы показали w килограмм. Поспешно прибежав домой, изнемогая от жажды, 
// ребята начали делить приобретенную ягоду, однако перед ними встала нелегкая задача. Петя и Вася являются большими поклонниками 
// четных чисел, поэтому хотят поделить арбуз так, чтобы доля каждого весила именно четное число килограмм, при этом не обязательно, 
// чтобы доли были равными по величине. Ребята очень сильно устали и хотят скорее приступить к трапезе, поэтому Вы должны 
// подсказать им, удастся ли поделить арбуз, учитывая их пожелание. Разумеется, каждому должен достаться кусок положительного веса. 
// Сколько таких вариаций может быть(вывести каждую вариацию на экран)
// Входные данные
// В первой и единственной строке входных данных записано целое число w (1 ≤ w ≤ 100) — вес купленного ребятами арбуза
// 10 кг арбуз
// ВЫВОД
// 2 8
// 4,6
// 6,4
// 8,2
//



// System.Console.Clear();
// System.Console.WriteLine();

// int InputNumber(string message)
// {
//     System.Console.Write(message);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// bool Check (int weight)
// {
//     if (weight % 2 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }

// }

// int numb = InputNumber("Введите вес арбуза: ");

// if (Check(numb))
// {
//     Console.WriteLine();
//     for ( int i = 2; i < numb; i +=2 )
//     {
//         System.Console.Write(i + " / ");
//         System.Console.WriteLine(numb - i);
//     }
//     Console.WriteLine();
// }
// else
// {
//     Console.WriteLine();
//     Console.WriteLine("Арбуз четно не делится!");
//     Console.WriteLine();
// }



//====================================================================================== 
//
// Задать N и вывести # до N елочкой 
// пример
// N = 2;
//   # 
//  ###
//
// N = 5
//     # 
//    ###
//   #####
//
// N = 7
//   #   
//  ###  
// ##### 
//#######

// Двумерный цикл 
// Если у нас не должно быть # , то пишем пробел
//

// System.Console.Clear();
// System.Console.WriteLine();

// int InputNumber(string message)
// {
//     System.Console.Write(message);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int numb = InputNumber("Введите число N (нечетное): ");

// bool Check (int weight)
// {
//     if (weight % 2 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// if (Check(numb))
// {
//     Console.WriteLine();
//     Console.WriteLine("Число четное!");
//     Console.WriteLine();
// }
// else
// {
//     int x = (numb + 1)/2;
//     for ( int i = 1; i <= x; i++ )
//     {
//         for ( int j = 1; j <= (x - i); j++)
//         {
//             Console.Write(" ");
//         }

//         for ( int j = 1; j <= (2*i-1); j++)
//         {
//             Console.Write("*");
//         }

//         for ( int j = 1; j <= (x - i); j++)
//         {
//             Console.Write(" ");
//         }
//     Console.WriteLine();
//     }
// }

//======================================================================================
//
// У нас есть кеш - N $ , мы хотим сохранить его от инфляции, кладем в банк и получаем раз в год M % , 
// через сколько лет у нас получится купить квартиру за K $ , при том , что цена квартиры также растет на Q % 
// если этот процент больше или равен N , то вывести в консоль безысходность 

System.Console.Clear();
System.Console.WriteLine();

double InputNumber(string message)
{
    System.Console.Write(message);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double cash = InputNumber("Введите сумму cash: ");
double flat = InputNumber("Введите сумму квартиры: ");
double procCash = InputNumber("Введите процент в банке: ");
double procFlat = InputNumber("Введите процент дорожания квартиры: ");

int count = 1;

while ( cash < flat )
{
    cash = cash + cash / 100 * procCash;
    flat = flat + flat / 100 * procFlat;

    System.Console.WriteLine(cash);
    System.Console.WriteLine(flat);
    System.Console.WriteLine(count);
    System.Console.WriteLine();

    count++;
}