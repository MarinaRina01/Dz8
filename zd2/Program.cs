
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int rows = SetNumber("строк");
int colomns = SetNumber("столбцов");

int[,] matrix = GetRandomMatrix(rows, colomns, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
int line = MinSumLine(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {line = line+1}");



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

int GetSum(int[,] matrix, int i)
{
    int sum = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
    return sum;
}

int MinSumLine(int[,] matrix)
{
    int minSum = GetSum(matrix, 0);
    int line = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (minSum > GetSum(matrix, i))
        {
            minSum = GetSum(matrix, i);
            line = i;
        }

    }
    return line;
}



