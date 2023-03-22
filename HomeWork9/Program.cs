//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
int ShowNum(int N, int M)
{
    if(N == M) return N;
    else Console.Write($"{ShowNum(N, M + 1)}, ");
    return M; 
}

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1)
{
  Console.WriteLine("Ввдите положительное число!");
  return;
}
Console.WriteLine(ShowNum(N, 1));
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNaturalElements(int n, int m)
{
  if (n == m) return n;
  else return SumNaturalElements(n + 1, m) + n;
}

Console.Write("Input a number n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number m : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNaturalElements(n, m));
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Input a number m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number n : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана от ({m},{n}) = {Akkerman(m, n)}");
*/