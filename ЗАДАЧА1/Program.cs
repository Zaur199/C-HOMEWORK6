// Показать двумерный массив размером m×n заполненный вещественными числами
void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,9);
        }
    }
}

int[,] matr = new int[4,4];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
PrintArray(matr);