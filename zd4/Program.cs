
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rows = SetNumber("X");
int colomns = SetNumber("Y");
int z = SetNumber("Z");
int[,,] matrix = GetRandomMatrix(rows, colomns, z, 10, 99);
PrintMatrix(matrix);
Console.WriteLine();



int SetNumber(string text)
{
    Console.Write($"Введите {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,,] GetRandomMatrix(int rows, int colomns, int z, int min, int max)
{
    int[,,] array = new int[rows, colomns, z];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand.Next(min, max + 1);
            }
        }
    }
    return array;

}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.Write("");
        
    }
}

