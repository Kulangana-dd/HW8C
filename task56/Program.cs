/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int RowMinAmount(int[,] finalarray)
{
    int[] sum = new int[finalarray.GetLength(0)];
    for (int i = 0; i < finalarray.GetLength(0); i++)
    {
        for (int j = 0; j < finalarray.GetLength(1); j++)
        {
            sum[i] = sum[i] + finalarray[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки: {sum[i]}");
    }
    int min = sum[0];
    int k = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] <= min)
        {
            min = sum[i];
            k = i;
        }
    }
    return k + 1;
}

int[,] array = new int[5, 4];

FillTwoDArray(array);
PrintTwoDArray(array);
Console.WriteLine();

int rezult = RowMinAmount(array);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в строке {rezult}");