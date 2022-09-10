// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

string MiddleRes(int[,] matr)
{
    string result = string.Empty;
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        double count = 0;
        double mean = 0; // Среднее арифметическое может быть не целое число, поэтому используем double
        for(int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i,j];
            count++;
        }
        mean = sum/count;
        result = result + mean.ToString() + " ";
    }
    return result;
}

int[,] matr = new int[3,3];
PrintArray(matr);
FillArray(matr);
Console.Write("Среднее арифметическое столбцов: ");
Console.WriteLine(MiddleRes(matr));
PrintArray(matr);