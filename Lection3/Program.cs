// Методы (функции):
// Первая группа методов-void "void Metod1()"
// Вторая группа-"void Metod2(string msg)"  где void ключевое слово, дальше идентификатор, в скобках
// указаны какие-то аргументы.
// Третья группа-Эти методы, которые что-то возвращают, но ничего не принимают. Если метод что-то
// возвращает, мы в обязательном порядке должны указать тип данных, значение которого
// ожидаем.
/*
int Metod3() - не принимает никакие аргументы
{
return DataTime.Now.Year; - обязательное использование оператора return,
}
int year = Metod3(); - вызываем метод, в левой части используем идентификатор
переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);
*/

// // Задача. Перевернуть массив от мин чисел к бОльшим.

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length -1; i++)
//     {
//     int minPosition = i;

//     for (int j = i + 1; j < array.Length; j++)
//     {
//         if(array[j] < array[minPosition])
//         minPosition = j;
//     }

//     int temporary = array[i];
//     array[i] = array[minPosition];
//     array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);