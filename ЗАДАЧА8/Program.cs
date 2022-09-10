// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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


int MinSum(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minNumStr = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(i == 0)
            {
                sum = sum + matr[i, j];
                minSum = minSum + matr[i, j];
            }

            else
                sum = sum + matr[i, j];

        }
        if(sum < minSum)
        {
            sum = minSum;
            minNumStr = i;
        }
        sum = 0;

    
    }
    return minNumStr;
}

int[,] matr = new int[5,6];
FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSum(matr)}");
