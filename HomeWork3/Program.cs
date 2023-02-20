// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
bool PalindromeOrNot(int number)
{
    int n = number;
    int rev = 0;
        while (n > 0)
        {
            int r = n % 10;
            rev = rev * 10 + r;
            n = n / 10;
        }
    return (number == rev);
}

Console.Write("Please insert number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = PalindromeOrNot(number);
if (result)
    Console.WriteLine($"Number {number} is a Palindrom of the insert number");
else
    Console.WriteLine($"Number {number} is not a Palindrom of the insert number");

*/
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double getDistance(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
}

Console.Write("Введите координату Х первой точки:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки:");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х второй точки:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки:");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки:");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками: " + Math.Round(getDistance(xa, ya, za, xb, yb, zb), 2));

*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void cubeTable(int n)
{
    int currentNumber = 1;
    while(currentNumber <= n)
    {Console.WriteLine(currentNumber * currentNumber * currentNumber);
    currentNumber++;
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
    cubeTable(n);
else
    Console.Write("Введите число больше 0!");
*/    