/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

void FillTwoDArray(int[,] twoDArray)
{
    for (int i = 0; i < twoDArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDArray.GetLength(1); j++)
        {
            twoDArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintTwoDArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void MultiplicationArrays(int[,] arr1, int[,] arr2, int[,] multiArray)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int multi = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                multi = multi + (arr1[i, k] * arr2[k, j]);
            }
            multiArray[i, j] = multi;
        }
    }
}

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];

FillTwoDArray(array1);
PrintTwoDArray(array1);
Console.WriteLine();

FillTwoDArray(array2);
PrintTwoDArray(array2);
Console.WriteLine();

int[,] multiplicationArrays = new int[2, 2];
Console.WriteLine("Произведение двух матриц:  ");
MultiplicationArrays(array1, array2, multiplicationArrays);
PrintTwoDArray(multiplicationArrays);
