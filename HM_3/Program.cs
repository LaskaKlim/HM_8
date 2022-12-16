Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];

int[,] matrixA = new int[linesVol, columnsVol];
int[,] matrixB = new int[linesVol, columnsVol];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);

Console.WriteLine();
Console.WriteLine("Первая матрица ");
PrintArray(matrixA);
Console.WriteLine("Вторая матрица ");
PrintArray(matrixB);

  int[,] matrixC = new int[linesVol, columnsVol];
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
              for (int k = 0; k < matrixA.GetLength(0); k++)
              {
               
                    matrixC[i, j] =  matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
                
              }
            }
        }

Console.WriteLine(" Произведение заданных матриц ");
PrintArray(matrixC);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}