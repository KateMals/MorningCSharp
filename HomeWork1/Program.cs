// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт какое число большее, а какое меньшее.
// 1) a = 5; b = 7 -> max = 7
/*
int a = 5;
int b = 7;
if (a > b)
Console.Write(a);
else
Console.Write(b);
*/

// 2) a = 2 b = 10 -> max = 10
/*
int a = 2;
int b = 10;
if (a > b)
Console.Write(a);
else
Console.Write(b);
*/

// 3) a = -9 b = -3 -> max = -3
/*
int a = -9;
int b = -3;
if (a > b)
Console.Write(a);
else
Console.Write(b);
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 1) 2, 3, 7 -> 7

/*
int a = 2;
int b = 3;
int c = 7;
int max = a;
if (b > max)
max = b;
if (c > max)
max = c;
Console.WriteLine("max = " + max);
*/

// 2) 44 5 78 -> 78

/*
int a = 44;
int b = 5;
int c = 78;
int max = a;
if (b > max)
max = b;
if (c > max)
max = c;
Console.WriteLine("max = " + max);
*/

// 3) 22 3 9 -> 22
/*
int a = 22;
int b = 3;
int c = 9;
int max = a;
if (b > max)
max = b;
if (c > max)
max = c;
Console.WriteLine("max = " + max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

//1) 4 -> да 2) -3 -> нет 3) 7 -> нет

/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0 )
    Console.WriteLine("ДА!");
else
    Console.WriteLine("НЕТ!");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
*/