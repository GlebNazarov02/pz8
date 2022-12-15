void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j], 6} ");
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
            arr[i, j] = new Random().Next(from,to);
        }
    }
    return arr;
}

void Zamena(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int j = 0; j < column; j++)
    {   
        (arr[0,j],arr[row-1,j])=(arr[row-1,j],arr[0,j]);
    } 
}

int[,] arr1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr1);
Zamena(arr1);
Console.WriteLine();
Print(arr1);