// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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

void ChangeToIndex(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i = i + 2)
    {
        for(int j = 0; j < matr.GetLength(1); j = j + 2)
        {
            matr[i,j] =  matr[i,j] *  matr[i,j];
        }
    }
}

int[,] matr = new int[5,5];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
ChangeToIndex(matr);
PrintArray(matr);