// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int rows = 2;
int colomns = 2;
int[,] matrixOne = GetRandomMatrix(rows, colomns, 1, 4);
PrintMatrix(matrixOne);
Console.WriteLine();
int[,] matrixTwo = GetRandomMatrix(rows, colomns, 1, 4);
PrintMatrix(matrixTwo);
Console.WriteLine();
int[,] array = Proizvedenie(matrixOne, matrixTwo);
PrintMatrix(array);

int[,] GetRandomMatrix(int rows, int colomns, int min, int max)
{
    int[,] array = new int[rows, colomns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;

}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Proizvedenie(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] array = new int[2, 2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int sum = 0;
            for (int l = 0; l < matrixOne.GetLength(1); l++)
            {
                sum= sum +matrixOne[i, l] * matrixTwo[l, j];
            }
             array[i, j] = sum;
        }

    }
    return array;
}
