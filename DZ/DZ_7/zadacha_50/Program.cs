// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
Console.WriteLine();

uint rows;
uint columns;
RowsRead();
ColumnsRead();

int[,] array = CreateRandomArray(rows, columns);
PrintArray(array);
int number;
ReadNumber();
ElementPosition(array);

void ReadNumber()
{
    Console.WriteLine("Введите число которое хотите найти ");
    while (!int.TryParse(Console.ReadLine()!, out number) || (number == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите число которое хотите найти ");
    }
}

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
    Console.WriteLine();
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

void ElementPosition (int[,] array)
{
    if (number > 1 || number < 10)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == number)
                {
                    Console.WriteLine($"Позиция искомого числа: строка {i + 1} столбец {j + 1}");
                }
            }
        }
    }
    if(number < 0 || number >= 10)
    {
        Console.WriteLine("Такого числа нет в таблице ");
    }
}
