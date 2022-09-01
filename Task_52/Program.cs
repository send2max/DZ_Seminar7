// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.WriteLine();
Console.Clear();

int[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void AverageArithmetic(int[,] array)
{
     Console.WriteLine($"Среднее арифметическое элементов столбца массива");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double meanarithmetic = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            meanarithmetic = meanarithmetic + array[j, i];
        }
        meanarithmetic = Math.Round(meanarithmetic / array.GetLength(1), 1);

        Console.WriteLine($" {meanarithmetic}");
    }


}

int[,] array = CreateMtrixRndInt(4, 4, 1, 10);
PrintMatrix(array);
Console.WriteLine ();
AverageArithmetic(array);