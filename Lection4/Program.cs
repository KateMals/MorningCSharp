/* Двумерные массивы string[,] table= new string[2,3]; - таблица из строк
int[,]matrix = new int[5,8]; - таблица чисел (матрица)
                  строки|столбцы
*/
// string.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
/*
string[,] table= new string[2, 5];
table[1, 2]   = "слово";
for(int rows = 0; rows < 2; rows++)
{
    for(int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"{table[rows, colums]}-");
    }
}
*/
/*
int[,]matrix = new int[4, 3];
for(int i = 0; i < 4; i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();   
}
*/
/*
Рекурсия - функция, которая вызывает сама себя.
5! = 5*4*3*2*1 =5*4!
4!= 4 * 3!
3!= 3 * 2!
*/