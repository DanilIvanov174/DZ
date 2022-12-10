Console.WriteLine("Программа, которая заполняет спирально массив n на n.");

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetSpiral(n);
PrintArray(array);

int[,] GetSpiral(int n)
{
    int[,] array = new int[n, n];
    int startValue = 1;
    for (int i = 1; i < n; i++)
    {
        for (int j = i - 1; j < n - i + 1; j++)
        {
            array[i - 1, j] = startValue++;
        }
        for (int j = i; j < n - i + 1; j++)
        {
            array[j, n - i] = startValue++;
        }
        for (int j = n - i - 1; j >= i - 1; j--)
        {
            array[n - i, j] = startValue++;
        }
        for (int j = n - i - 1; j >= i; j--)
        {
            array[j, i - 1] = startValue++;
        }
    }
    return array;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
}
