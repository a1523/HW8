/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] GetArray (int n, int m)
{
    int[,] array = new int[n,m];
    Random rand = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(0, 10);
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

int[,] GetMatrixMult (int[,] arr1, int[,] arr2)
{
    int[,] array1 = new int [arr1.GetLength(0), arr1.GetLength(1)];
    int[,] array2 = new int [arr2.GetLength(0), arr2.GetLength(1)];
    int[,] arrayResult = new int[arr1.GetLength(0), arr2.GetLength(1)];

    if(arr1.GetLength(1) != arr2.GetLength(0))
    {
        Console.WriteLine("Произведение матриц невозможно!");
    
    }
       
    for(int i =0; i < arr1.GetLength(0); i++)
    {
        for(int j =0; j < arr2.GetLength(1); j++)
        {
            arrayResult[i,j] = 0;
            for(int z =0; z < arr1.GetLength(1); z++)
            {
            arrayResult[i,j] += arr1[i,z]*arr2[z,j];
            }
        }
    }
    return arrayResult;
}


Console.Write("Введите количество строк в массиве №1 (n1):");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве № 1 (m1):");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк в массиве №2 (n2):");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве № 2 (m2):");
int m2 = Convert.ToInt32(Console.ReadLine());

int [,] array1 = GetArray(n1, m1);
Console.WriteLine("Исходный массив № 1");
PrintArray(array1);

int [,] array2 = GetArray(n2, m2);
Console.WriteLine("Исходный массив № 2");
PrintArray(array2);

int[,] arrayResult = GetMatrixMult (array1, array2);

Console.WriteLine("Произведение матриц:");
PrintArray(arrayResult);
