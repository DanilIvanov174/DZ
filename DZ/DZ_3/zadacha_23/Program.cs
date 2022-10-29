Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine()!);


int[] GetSqrtTable(int N)
{
    int[] SqrtArray = new int[N];
    
    for (int i = 0; i < N; i++)
    {
        SqrtArray[i] = (i + 1) * (i + 1) * (i + 1);
    }

    return SqrtArray;
}

void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"{number} ^ 3 = {Array[i]}");
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);
