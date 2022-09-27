/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int GetRowMinSum (int [,] array)
{
    int sumRow = 0;
    int minSumRow = 0;
    int minRow = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        minSumRow += array[0,i];
    }
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                sumRow += array[i,j];
                if(sumRow < minSumRow)
                {
                    minSumRow = sumRow;
                    minRow = i;
                }
            sumRow = 0;
            }
        }
    return minRow;       
}


int[,] GetArray (int n, int m)
{
    int[,] array = new int[n,m];
    Random rand = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(-10, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return;
}

try{
Console.Write("Введите количество строк в массиве (n):");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве (m):");
int m = Convert.ToInt32(Console.ReadLine());

int [,] array = GetArray(n, m);
Console.WriteLine("Исходный массив");
PrintArray(array);

int result = GetRowMinSum(array);
Console.WriteLine($"Минимальная сумма всех значений массива в {result+1} строке");
}
catch
{
    Console.WriteLine("Ошибка! Не корректный ввод данных. Введите целое число");
}


