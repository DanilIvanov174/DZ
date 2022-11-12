Console.WriteLine("Программа, которая выводит сумму элементов нечётных позиций в массиве ");
Console.WriteLine("Введите длинну массива");

ReadLine();
uint length;

int[] array = new int[length];

RandomArray(array);
PrintArray(array);
EvenIndex(array);

void ReadLine()                   // Функция считывания положительного числа из консоли
{
    while (!uint.TryParse(Console.ReadLine()!, out length))
    {
        Console.WriteLine("Неверный ввод");
        Console.WriteLine("Введите целое положительное число");
    }
}

void EvenIndex(int[] array)       // Функция вывода суммы нечётных элементов в массиве
{
    int sum = 0;
    for (int i = 1; i < length; i+=2)
    {
        sum = array[i] + sum; 
            
    }
    Console.WriteLine("Сумма нечётных элементов в массиве = " + sum);
}

void RandomArray(int[] array)     // Функция заполнения массива в случайном порядке
{
    Random random = new Random();
    Console.WriteLine("Сгенерированный массив");
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100, 100);
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