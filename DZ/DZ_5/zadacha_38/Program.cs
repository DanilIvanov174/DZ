Console.WriteLine("Программа, которая находит разницу между максимальным и минимальным элементом массива ");
Console.WriteLine("Введите длинну массива");

ReadLine();
uint length;

double[] array = new double[length];

RandomArray(array);
PrintArray(array);
MaxMinDif(array);

void ReadLine()                      // Функция считывания положительного числа из консоли
{
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Введите целое положительное число");
    }
}

void RandomArray(double[] array)     // Функция заполнения массива в случайном порядке
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив ");
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(random.Next(-100, 100) + random.NextDouble(), 2);
    }
}

void PrintArray(double[] array)      // Функция вывода массива в консоль
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void MaxMinDif(double[] array)       // Функция вывода разницы максимального и минимального элемента массива
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
        }
    }
    double difference = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + difference);
}

