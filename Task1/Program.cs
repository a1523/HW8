/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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

int[,] GetArrayOrdered(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int z = 0; z < array.GetLength(1)-1; z++)
            {    
                if(array[j,z] > array[j,z+1])
                {
                    int tmp = 0;
                    tmp = array[j,z];
                    array[j,z] = array[j,z+1];
                    array[j,z+1] = tmp;
                }
            }
        
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

Console.Write("Введите количество строк в массиве (n):");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве (m):");
int m = Convert.ToInt32(Console.ReadLine());

int [,] array = GetArray(n, m);
Console.WriteLine("Исходный массив");
PrintArray(array);

int [,] arrayNew = GetArrayOrdered(array);
Console.WriteLine("Отсортированный массив: ");
PrintArray(arrayNew);