// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

/*
int CountEven(int[] array)
{
    int counter = 0;
    {
    for(int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 0)
    counter++;
    }
return counter;
}

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

int[] newArray = CreateRandomArray(5, 100, 999);
ShowArray(newArray);
int result = CountEven(newArray);
Console.WriteLine($"the number of even elements in the array: {result} ");
*/

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0
/*
int GetSumOddNumber(int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
    if (i % 2 > 0)
    sum = sum + array[i];
return sum;    
}

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
int result = GetSumOddNumber(newArray);
Console.WriteLine($"the sum of odd elements in the array: {result} ");
*/

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

/*
double foundMaxMin(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    double dif = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(Max < array[i])
        {
        Max = array[i];
        }
        if(Min > array[i])
        {
        Min = array[i];
        }
    }
    dif = Max - Min;
return dif;  
}
double[] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];

    for(int i =0; i < size; i++)
    {
        array[i] = Math.Round(minValue + new Random().NextDouble()*(maxValue - minValue),2);
    }
    return array;
}

void ShowArray(double [] array)
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

double[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

double result = foundMaxMin(newArray);
Console.WriteLine($"the dif from Max and Min of array: {result} ");
*/