/* задайте двумерный массив размером m*n, заполненный случайными вещественными числами*/

double[,] GetArray( int rows, int columns)
{
    double[,] array = new double[rows, columns];
    var newRand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round((newRand.NextDouble() * (100 - 1) + 1),0);
        }
    }
    return array;
}

void PrintArray (double [,] array)
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

double[,] arr = GetArray(3,4);
PrintArray(arr);