
Console.Write("Введите номер дня недели: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

if ((Number1 < 1) || (Number1 > 7))  Console.Write("Это не день недели"); 
if ( Number1 == 1 ) Console.Write("Понедельник"); 
if ( Number1 == 2 ) Console.Write("Вторник"); 
if ( Number1 == 3 ) Console.Write("Среда"); 
if ( Number1 == 4 ) Console.Write("Четверг"); 
if ( Number1 == 5 ) Console.Write("Пятница"); 
if ( Number1 == 6 ) Console.Write("Суббота"); 
if ( Number1 == 7 ) Console.Write("Воскресенье"); 
