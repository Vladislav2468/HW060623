// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


int[,] MultiplyMatrices(int[,] matrixx1, int[,] matrixx2)
{
    int rows1 = matrixx1.GetLength(0);
    int columns1 = matrixx1.GetLength(1);
    int rows2 = matrixx2.GetLength(0);
    int columns2 = matrixx2.GetLength(1);
    if (columns1 != rows2)
    {
        throw new ArgumentException("Невозможно умножить матрицы.");
    }
    int[,] result = new int[rows1, columns2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum += matrixx1[i, k] * matrixx2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}


void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = GetArray(2, 2, 1, 10);
int[,] matrix2 = GetArray(2, 2, 1, 10);
int[,] result = MultiplyMatrices(matrix1, matrix2);

PrintMatrix(matrix1);
Console.WriteLine("========");
PrintMatrix(matrix2);
Console.WriteLine("========");
PrintMatrix(result);

