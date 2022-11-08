/* Напишите функцию, которая принимает на вход 2 числа (А и В)
и возводит число А в натуральную степень В. */

Console.WriteLine("Программа которая возводит число А в степень В");

Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine()!);


void Exponentiation()
{
    int count = 0;
    double result = 1;

    // Для положительной степени

    if (numberB > 0)
    {
        while (count < numberB)
        {
            result = result * numberA;
            count++;
        }
        Console.WriteLine("Результат " + numberA + " ^ " + numberB + " = " + result);
    }

    // Для отрицательной степени

    else
    {
        while (count != numberB)
        {
            result = result * numberA;
            count--;
        }
        Console.WriteLine("Результат " + numberA + " ^ " + numberB + " = " + (1 / result));
    }
}

Exponentiation();
