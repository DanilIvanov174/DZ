Console.WriteLine();
Console.WriteLine("Программа которая задает двумерный массив m*n заполненный случайными вещественными числами");

uint rows;
uint columns;
RowsRead();
ColumnsRead();

double[,] array = CreateRandomArray(rows, columns);
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

double[,] CreateRandomArray(uint rows, uint columns)   // Функция заполнения массива случайными числами
{
    double[,] array = new double [rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = Math.Round(random.Next(0, 10) + random.NextDouble(), 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)      // Функция вывода массива в консоль
{
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
