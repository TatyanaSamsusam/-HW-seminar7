/* задача 52. задайте двумерный массив из целых чисел. найдите среднее арифметическое элементов в каждом столбце*/

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)              
    {
        for (int j = 0; j < array.GetLength(1); j++)          
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] arr = GetArray(3, 4);
PrintArray(arr);

for (int j = 0; j < arr.GetLength(1); j++)                    
{
    double sum = 0;                                           
        for (int i = 0; i < arr.GetLength(0); i++)            
        {
            sum = sum + arr[i,j];                             
        }
    double aver = Math.Round(sum / arr.GetLength(0),1);
    Console.WriteLine($"среднее арифметическое столбца {j+1} равно {aver}");
}


