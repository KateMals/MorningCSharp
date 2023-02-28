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






// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76