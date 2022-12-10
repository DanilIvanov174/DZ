
Console.WriteLine("Программа, которая построчно выводит массив, добавляя индексы каждого элемента.");

Console.Write("Введите размеры массива ");
int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);
int z = int.Parse(Console.ReadLine()!);

int[,,] array = GetArray(x, y, z);
Console.WriteLine("Полученный массив:");
PrintArray(array);


int[,,] GetArray(int x, int y, int z)
{
    
    Random newRandom = new Random();
    int[,,] array = new int[x, y, z];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2);)
            {
                bool alreadyThere = false;
                int randomNumber = newRandom.Next(10, 100);

                for (int a = 0; a < x; a++)
                {
                    for (int b = 0; b < y; b++)
                    {
                        for (int c = 0; c < z; c++)
                        {
                            if (array[a, b, c] == randomNumber)
                            {
                                alreadyThere = true;
                                break;
                            }
                        }
                    }
                }
                if (!alreadyThere)
                {
                    array[i, j, k] = randomNumber;
                    k++;
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}
