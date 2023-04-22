
// Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = SetNumber("строк");
int colomns = SetNumber("столбцов");
int [,] matrix= new int[rows, colomns];


int tmp=1;
int i = 0;
int j = 0;
while(tmp <= matrix.GetLength(0) * matrix.GetLength(1) )
{
    matrix [i,j] = tmp;
    tmp++;
   if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
 
PrintMatrix(matrix);

int SetNumber(string text)
{
    Console.Write($"Введите количество {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if( matrix[i,j]/10 == 0)
            {
                Console.Write($"0{matrix[i, j]} ");
            }
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
