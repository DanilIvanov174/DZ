Console.WriteLine("Программа, которая показывает кол-во чётных чисел в массиве ");
Console.WriteLine("Введите длинну массива");

ReadLine();
uint length;

int[] array = new int[length];

RandomArray(array);
PrintArray(array);
EvenNumbers(array);

void ReadLine()                   // Функция считывания положительного числа из консоли
{
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Введите целое положительное число");
    }
}

void EvenNumbers(int[] array)     // Функция вывода кол-ва чётных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("Кол-во чётных чисел в массиве = " + count);
}

void RandomArray(int[] array)     // Функция заполнения массива в случайном порядке
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив");
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] array)      // Функция вывода массива в консоль
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}