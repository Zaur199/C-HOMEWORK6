// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void PrintArray(int[,] matr)
{
    for(int m = 0; m < matr.GetLength(0); m++)
    {
        for(int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m,n]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int m = 0; m < matr.GetLength(0); m++)
    {
        for(int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m,n] = new Random().Next(1,9);
        }
    }
}

void SumArray(int[,] matr)
{
    for(int m = 0; m < matr.GetLength(0); m++)
    {
         for(int n = 0; n < matr.GetLength(1); n++)
         {
            matr[m,n] = m + n;
         }
    }
}

int[,] matr = new int[6,6];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
SumArray(matr);
PrintArray(matr);