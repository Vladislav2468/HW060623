//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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


int FindRowWithMinSum(int[,] arr)
{
    int numRows = arr.GetLength(0);
    int numColumns = arr.GetLength(1);    
    int minSum = int.MaxValue;
    int minSumRow = -1;
    for (int row = 0; row < numRows; row++)
    {
        int rowSum = 0;
        for (int column = 0; column < numColumns; column++)
        {
            rowSum += arr[row, column];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRow = row;
        }
    }
    return minSumRow;
}


void PrintArray(int[,] arrr)
{
    int numRows = arrr.GetLength(0);
    int numColumns = arrr.GetLength(1);

    for (int row = 0; row < numRows; row++)
    {
        for (int column = 0; column < numColumns; column++)
        {
            Console.Write($"{arrr[row, column]} ");
        }
        Console.WriteLine();
    }
}

int [,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
int minSumRow = FindRowWithMinSum(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
