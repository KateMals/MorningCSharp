// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.
/*
1 генерирующие методы -сформировать новый массив
2 аналитические - существующий массив берут и не меняя его выполняет расчеты
3 преобразующие - существующий массив берут и вносят необходимые изменения
*/
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

int GetNegativeSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }

    return sum;
}

Console.Write("Input a quantity of elements ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posible value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
int result = GetNegativeSum(newArray);
Console.WriteLine($"Sum of negative numbers is " + result);
*/

// Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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

int[] ChangePosAndNeg(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= -1;
    return array;
}

Console.Write("Input a quantity of elements ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posible value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
ShowArray(ChangePosAndNeg(newArray));

*/

//Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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

bool FindNumber(int [] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        return true;    
    }
    return false;
}

Console.Write("Input a quantity of elements ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posible value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posible value ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
bool result = FindNumber(newArray, number);
if (result)
    Console.WriteLine($"Number {number} at the array");
else
Console.WriteLine($"Number {number} not on a array");
*/

// Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
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

int CountNumbers(int [] array, int A, int B)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] >= A && array[i] <= B)
        counter++;
    }
    return counter;
}

Console.Write("Input A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B ");
int B = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(12, 1, 40);
ShowArray(newArray);

int result = CountNumbers(newArray,A, B);
Console.WriteLine($"There are a {result} numbers on a array");
*/