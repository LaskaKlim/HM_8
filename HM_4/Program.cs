int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);

Console.Write("Сгенерированный трехмерный массив: ");
PrintIndex(array3D);

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] arr)
{  
 
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
      
       for (int j = 0; j < array3D.GetLength(1); j++)
        {  
            Console.WriteLine();  
            Console.Write("[ ");  
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.Write("] ");
        }
        

      
    }   
   
}


