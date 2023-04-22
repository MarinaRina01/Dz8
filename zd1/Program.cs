// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = SetNumber("строк");
int colomns = SetNumber("столбцов");

int[,] matrix = GetRandomMatrix(rows, colomns, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
Perebor(matrix);
PrintMatrix(matrix);

int SetNumber(string text)
{
    Console.Write($"Введите количество {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

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

int[,] Perebor(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(1) - 1; l++)
            {
                if (matrix[i, l] < matrix[i, l + 1])
                {
                    int tmp = matrix[i, l + 1];
                    matrix[i, l + 1] = matrix[i, l];
                    matrix[i, l] = tmp;
                }
            }
        }
    }
    return matrix;
}

