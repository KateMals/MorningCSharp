// Рекурсивный метод-функция которая вызывает сама себя.Рекурсия похожа на цикл.

// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5);
*/
//Напишите программу, которая будет принимать
//на вход число и возвращать сумму его цифр.
/*
int SumOfGigits(int num)
{
    if(num / 10 != 0) return SumOfGigits(num / 10) + Math.Abs(num % 10);
    return Math.Abs(num);
}

Console.WriteLine(SumOfGigits(-1234));

f(1234) -- f(123) + 4
f(123) -- f(12) + 3
f(12) -- f(1) + 2
f(1) -- 1
f(12) -- 1 + 2 = 3
f(123) -- 3 + 3 = 6
f(1234) -- 6 + 4 = 10

*/

// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumsWithinNums(int M, int N)
{
    if (M == N) 
        Console.Write(M + " ");
    else
    {
        if (M > N)
        {
            Console.Write(M + " ");
            ShowNumsWithinNums(M - 1, N);
        }
        else
        {
            ShowNumsWithinNums(M, N - 1);
            Console.Write(N + " ");
        }
    }
}

ShowNumsWithinNums(20, 1);
*/

// Напишите программу, которая на вход принимает два числа 
// A и B, и возводит число А в целую степень B.

double PowerOfNum(double num, int pow)
{
    if(pow == 0) return 1;
    else
    {
        if(pow > 0)
            return PowerOfNum(num, pow - 1) * num;
        else
            return PowerOfNum(num, pow + 1) / num;

    }
}

Console.WriteLine(PowerOfNum(2,-5));