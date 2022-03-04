// Найти произведение двух матриц.

Console.Clear();

Random rnd = new Random();
int[,] arrayA = new int[4, 4];
int[,] arrayB = new int[4, 4];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 5);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

FillArray(arrayA);
FillArray(arrayB);
Console.WriteLine();
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);

int[,] multArray = new int[arrayA.GetLength(1), arrayB.GetLength(0)];

void MultArrays(int[,] first, int[,] second, int[,] result)
{
    for (int i = 0; i < first.GetLength(1); i++)
    {
        for (int j = 0; j < second.GetLength(0); j++)
        {
            for (int k = 0; k < first.GetLength(1); k++)
            {
                result[i, j] += first[i, k] * second[k, j];
            }
        }
    }
}

Console.WriteLine();
MultArrays(arrayA, arrayB, multArray);
Console.WriteLine();
PrintArray(multArray);