Console.WriteLine();
Console.WriteLine("Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива");
Console.WriteLine();

uint rows;
uint columns;
RowsRead();
ColumnsRead();

int[,] array = CreateRandomArray(rows, columns);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив ");
PrintArray(array);
Console.WriteLine("Отсортированный массив ");
OrderArrayLines(array);
PrintArray(array);

void RowsRead() // Функция считывания количества строк из консоли
{
    Console.WriteLine("Введите количество строк ");
    while (!uint.TryParse(Console.ReadLine()!, out rows) || (rows == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество строк ");
    }
}

void ColumnsRead() // Функция считывания количества столбцов из консоли
{
    Console.WriteLine("Введите количество столбцов ");
    while (!uint.TryParse(Console.ReadLine()!, out columns) || (columns == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество столбцов ");
    }
}

int[,] CreateRandomArray(uint rows, uint columns) // Функция заполнения массива случайными числами
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array) // Функция вывода массива в консоль
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
