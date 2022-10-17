/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
            Console.Write($"{arrayToPrint[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void SortDescendingArray(int[,] sortArray)
{
    for (int i = 0; i < sortArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortArray.GetLength(1); j++)
        {
            for (int k = 0; k < sortArray.GetLength(1) - 1; k++)
            {
                if (sortArray[i, k] < sortArray[i, k + 1])
                {
                    int temp = sortArray[i, k + 1];
                    sortArray[i, k + 1] = sortArray[i, k];
                    sortArray[i, k] = temp;
                }
            }
        }
    }
}

int[,] array = new int[4, 4];

FillTwoDArray(array);
PrintTwoDArray(array);

SortDescendingArray(array);
Console.WriteLine();

Console.WriteLine("Отсортированный массив:");
PrintTwoDArray(array);