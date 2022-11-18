Console.WriteLine("Программа которая, находит среднее арифметическое элементов в каждом столбце.");

uint rows;
uint columns;
RowsRead();
ColumnsRead();

int[,] array = CreateRandomArray(rows, columns);
PrintArray(array);
PrintArithmeticMean(array);

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

int[,] CreateRandomArray(uint rows, uint columns)   // Функция заполнения массива случайными числами
{
    int[,] array = new int [rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)      // Функция вывода массива в консоль
{
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArithmeticMean(int[,] array)
{
   for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее арефметическое {j + 1} столбца {Math.Round (sum / array.GetLength(0), 1)} ");
    }
}