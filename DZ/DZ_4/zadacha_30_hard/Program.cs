/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке 
Далее надо посчитать количество нулей и единиц, 
если единиц больше чем нулей то вывести TRUE на экран, 
иначе вывести False. */

Console.WriteLine("Программа, которая создаёт массив с 0 и 1. Далее считает кол-во 0 и 1, если 1 > 0 выводит TRUE иначе False");

Console.WriteLine("Введите длинну массива");
int lenght = int.Parse(Console.ReadLine()!);

int[] array = new int[lenght];
Random random = new Random();


void RandomArray(int[] array)     // Функция заполнения массива 0 и 1 в случайном порядке
{
    int index = 0;
    while (index < lenght)
    {
        array[index] = random.Next(0, 2);
        index++;
    }
}

void PrintArray(int[] array)      // Функция вывода массива в консоль
{
    int index = 0;
    while (index < lenght)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

void TrueFolseArray (int[] array) // Функция определения True или Folse
{
    int maxcount = 0;
    int mincount = 0;
    int index = 0;
    while (index < lenght)
    {
        if (array[index] > 0)
        {
            maxcount++;
            index++;
        }
        else
        {
            mincount++;
            index++;
        }
    }

    if (maxcount > mincount)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("Folse");
    }
}

RandomArray(array);
Console.Write("Массив в строку ");
PrintArray(array);
TrueFolseArray(array);
