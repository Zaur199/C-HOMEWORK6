// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
int[,] array = new int[4, 5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int temp;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       for (int x = 0; x < array.GetLength(1) - j - 1; x++)
       {
            if(array[i, x] < array[i, x+1])
            {
                temp = array[i, x];
                array[i, x] = array[i, x+1];
                array[i, x+1] = temp;
            }
            
       }
    }
}

Console.WriteLine("Преобразованная матрица, в которои строки убывают по значению: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}