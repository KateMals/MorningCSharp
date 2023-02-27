// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*

int Degree(int A, int B)
{
    int degree = 1;
    for(int i = 0; i < B; i++)
    {
        degree *= A;
    }
    return degree;
}

Console.Write("Input a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a degree B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = Degree(A, B);
Console.WriteLine($"Degree {B} of number{A} is {result}");

*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumNumbers(int A)
{
    int sum = 0;

    for(int current = 1; current <= A; current++)
    {
        sum += A % 10;
        A = A / 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Sum of numbers {number} is {result}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i =0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a quantity of elements ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posible value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(size, min, max);
ShowArray(newArray);
*/