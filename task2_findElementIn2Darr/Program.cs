/* напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента, или же указание, что такого элемента нет.
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого элемента в массиве нет*/

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

Console.WriteLine("Введите индекс (строку и столбец через enter) элемента, и я напишу его значение");
int rowpos = int.Parse(Console.ReadLine());
int colpos = int.Parse(Console.ReadLine());

void GetValue (int[,] arr, int rowpos, int colpos)
{
    if (rowpos <= arr.GetLength(0) && colpos <= arr.GetLength(1))
        {
            Console.WriteLine($"под таким индексом стоит {arr.GetValue( rowpos, colpos)}"); 
        }
    else Console.WriteLine($"такого элемента нет");
}

GetValue(arr, rowpos, colpos);

