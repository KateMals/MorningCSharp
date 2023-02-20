// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
//  на выходе показывает вторую цифру этого числа.
/*
456 -> 5
782 -> 8
918 -> 1
*/

 /*
int secondNumber(int num)
{
    int cutDiv = num % 100;
    int cutUnits = num % 10;
    int result = (cutDiv- cutUnits) / 10;
    return result;
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Ошибка:Вы ввели не трёхзначное число");
    return;
}
int newNumber = secondNumber(number);
Console.WriteLine($"The second number {number} is {newNumber}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
/*
645 -> 5
78 -> третьей цифры нет
32679 -> 6
/*

int thirdNumber(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}
bool errorNumber(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры в данном числе нет!");
        return false;
    }
    return true;
}

Console.Write("Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());
if (errorNumber(num))
{
    Console.WriteLine(thirdNumber(num));
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
6 -> да
7 -> да
1 -> нет
*/
/*
bool dayWeek(int day)
{
    if(day == 6 || day == 7)
    return true;
    else
    return false;
}

Console.Write("Напишите цифру,соответсвующую дню недели: ");
int day = Convert.ToInt32(Console.ReadLine());

bool result = dayWeek(day);
if(result)
{
    Console.WriteLine($"This day of week {day} is weekend");
}
 else
{
    Console.WriteLine($"This day of week {day} is simple day");
}
*/
