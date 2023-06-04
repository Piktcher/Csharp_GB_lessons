// СОздание, наполнение и вывод двумерных массивов

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int col = 0; col < matr.GetLength(1); col++)
        {
            matr[rows, col] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[2, 5];
FillArray(matrix);
PrintArray(matrix);