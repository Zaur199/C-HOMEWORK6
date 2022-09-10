// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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

void ChangeSymbols(int[,] matr)
{
    if(matr.GetLength(0) == matr.GetLength(1))
    {
        int[,] numbers = new int[matr.GetLength(0), matr.GetLength(1)];
        for(int i = 0; i < matr.GetLength(0); i++)
        {
           for(int j = 0; j < matr.GetLength(1); j++)
           {
                numbers[i, j] = matr[i, j];
           } 
        }
        for(int i = 0; i < matr.GetLength(0); i++)
        {
            for(int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = numbers[i, j];
            }
        }
    }
    else
        Console.WriteLine("Матрица не квадратная");
}

int[,] matr = new int[5,5];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
ChangeSymbols(matr);
PrintArray(matr);