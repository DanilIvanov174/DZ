// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Программа которая, считает сколько чисел больше 0 ввёл пользователь.");

Console.WriteLine("Введите количество чисел ");
int lenght = int.Parse(Console.ReadLine()!);
int[] array = new int[lenght];

Console.WriteLine("Введите числа через 'Enter' ");
PrintArray(ReadArray(array));
int rezult = CountGreaterThanZero(array);
Console.WriteLine($"Количество чисел больше нуля = {rezult}");


int[] ReadArray(int[] array)  // Функция ввода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)  // Функция вывода массива
{
    Console.WriteLine();
    Console.WriteLine("Вы ввели числа ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountGreaterThanZero (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}
