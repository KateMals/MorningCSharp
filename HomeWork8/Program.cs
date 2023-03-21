//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{   
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();        
}

void OrderRowElements(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(newArray);
OrderRowElements(newArray);
Show2dArray(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{   
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();        
}

int GetRowNumber (int [,] array)
{
  int row = 0;
  int minsum = 0;
  for (int i = 0; i < array.GetLength(1); i++)
  {
    minsum = minsum + array[0,i];
  }
  for (int i = 1; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i,j];
    }
    if (minsum > sum)
    {
      minsum = sum;
      row = i;
    }
  }
  return row + 1;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(newArray);
Console.WriteLine($"Строка с наименьшей суммой: № {GetRowNumber(newArray)}");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateArray(int m, int n, int min, int max)
{
  int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      } 
    }
      return result;
}

void ShowArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
  }
}

int [,] GetMultiplicationArray(int[,] arrayA, int[,] arrayB)
{
int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
  for (int i = 0; i < arrayA.GetLength(0); i++)
  {
    for (int j = 0; j < arrayB.GetLength(1); j++)
    {
      for (int k = 0; k < arrayA.GetLength(1); k++)
      {
        arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
      }
    }
  }
return arrayC;
}

Console.Write("Input rows of array A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input colums of array A: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input rows of array B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input colums of array B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

if (columnsA != rowsB)
{
  Console.WriteLine("ERROR!");
  return;
}
int[,] A = CreateArray(rowsA, columnsA, 0, 10);
int[,] B = CreateArray(rowsB, columnsB, 0, 10);
ShowArray(A);
Console.WriteLine();
ShowArray(B);
Console.WriteLine();
ShowArray(GetMultiplicationArray(A,B));
*/

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
void Create3dArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void Show3dArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.Write("Input X : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[x, y, z];
Create3dArray(array3D);
Show3dArray(array3D);
*/


// Задача 62: Заполните спирально массив 4 на 4.
/*
void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int n = 4;
int[,] spiralArray = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
  spiralArray[i, j] = temp;
  temp++;
    if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
      j++;
    else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
      i++;
    else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
      j--;
    else
      i--;
}
ShowArray(spiralArray);
*/