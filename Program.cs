// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Start");

int a = 7123;

while  (a > 999) a = a / 10;
Console.WriteLine(a % 10);
    if (a < 100)
   {
        Console.WriteLine("третьей цифры нет");
   }


Console.WriteLine("END");   



//if (a < 100)

 // else
   // {
   //     Console.WriteLine("третьей цифры нет");
    //}
 