/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void FillThreeDArray(int[,,] threeDArray)
{
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                threeDArray[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

int NonRepeatingNumber(int[,,] arr, int number = 0)
{
    int nonRepeatingNumber = new Random().Next(10, 100);
    if (nonRepeatingNumber == number)
    {
        return NonRepeatingNumber(arr, number);
    }
    else
    {
        return nonRepeatingNumber;
    }
}

void PrintThreeDArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.Write($"{arrayToPrint[i, j, k]} ({i},{j},{k})");
                Console.WriteLine();
            }
        }
    }
}

int[,,] array = new int[2, 2, 2];
FillThreeDArray(array);
PrintThreeDArray(array);