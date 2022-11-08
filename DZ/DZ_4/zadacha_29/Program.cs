/* Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
и далее выводит массив на экран в одну строку. */


Console.WriteLine("Программа, которая задаёт массив с клавиатуры и далее выводит массив на экран в одну строку");

Console.WriteLine("Введите длинну массива");
int lenght = int.Parse(Console.ReadLine()!);

int[] array = new int[lenght];

// Функция ввода массива
Console.WriteLine("Введите числа массива через 'Enter' ");

void ReadArray(int[] array)
{

    int index = 0;
    while (index < lenght)
    {
        array[index] = int.Parse(Console.ReadLine()!);
        index++;
    }
}

// Функция вывода массива

void PrintArray(int[] array)
{

    int index = 0;
    while (index < lenght)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

ReadArray(array);
Console.Write("Массив в строку ");
PrintArray(array);