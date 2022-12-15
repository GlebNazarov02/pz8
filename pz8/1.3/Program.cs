void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j],6} ");
        }
        Console.WriteLine();
    }

}

int[,] MassNums(int s1, int s2, int from, int to)
{
    int[,] arr = new int[s1, s2];
    for (int i = 0; i < s1; i++)
    {
        for (int j = 0; j < s2; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}
int[,] ChtoYaDelau(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int maxi = 0;
    int maxj = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (arr[i, j] < arr[maxi, maxj])
            {
                maxi = i;
                maxj = j;
            }
        }
    }
    int[,] arr2 = new int[row - 1, column - 1];
    int i1;
    int j1;
    for (int i = 0; i < row - 1; i++)
    {
        if (i == maxi)
        {
            i1 = i + 1;
        }
        else
        {
            i1 = i;
        }
        for (int j = 0; j < column - 1; j++)
        {
            if (j == maxj)
            {
                j1 = j + 1;
            }
            else
            {
                j1 = j;
            }
            arr2[i, j] = arr[i1, j1];
        }
    }
    return arr2;
}
int[,] arr1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));

Print(arr1);
int[,] arr3 = ChtoYaDelau(arr1);
Console.WriteLine();
Print(arr3);