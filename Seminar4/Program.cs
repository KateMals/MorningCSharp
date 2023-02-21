// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int A)
{
    int sum = 0;

    for(int current = 1; current <= A; current++)
    {
        sum += current;
    }
    return sum;
}
// int current = 1;
// while(current <= a)
// {
//     sum += current;
//     current++;
// }

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetSum(number);
Console.WriteLine($"Sum of numbers from 1 to {number} is {result}");
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int GetNum(int num)
{
    int GetNum = 0;
    if (num == 0) GetNum=1;

    while (num > 0)
    {
        num /=10;
        GetNum++;
    }
    return GetNum;
}

Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());

int dig = GetNum(number);

Console.WriteLine($"There are {dig} digits in {number}");

*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int num)
{
    int result = 1;
    for(int current = 1; current <= num; current++)
    {
        result *= current;
    }
    return result;
}

Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = Factorial(number);
Console.WriteLine($"The * factorial of {number} is {factorial}");
*/

// Вывести на экран случайный массив, при заданном размере , мин и макс значении.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
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

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
*/