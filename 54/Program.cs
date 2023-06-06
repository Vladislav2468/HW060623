// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

int[,] SortRowsDescending(int[,] inarray)
{
    int numRows = inarray.GetLength(0);
    int numColumns = inarray.GetLength(1);
    int[,] sortedArray = new int[numRows, numColumns];
    Array.Copy(inarray, sortedArray, inarray.Length);
    for (int row = 0; row < numRows; row++)
    {
        for (int i = 0; i < numColumns - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < numColumns; j++)
            {
                if (sortedArray[row, j] > sortedArray[row, maxIndex])
                {
                    maxIndex = j;
                }
            }

            if (maxIndex != i)
            {
                int temp = sortedArray[row, i];
                sortedArray[row, i] = sortedArray[row, maxIndex];
                sortedArray[row, maxIndex] = temp;
            }
        }
    }
    return sortedArray;
}


void PrintArray(int[,] arr)
{
    int numRows = arr.GetLength(0);
    int numColumns = arr.GetLength(1);

    for (int row = 0; row < numRows; row++)
    {
        for (int column = 0; column < numColumns; column++)
        {
            Console.Write($"{arr[row, column]} ");
        }
        Console.WriteLine();
    }
}


int [,] array = GetArray(3, 4, 1, 10);
PrintArray(array);
Console.WriteLine("============");
int [,] sortArray = SortRowsDescending(array);
PrintArray(sortArray);

