Console.WriteLine("Программа, которая находит сумму натуральных чисел в промежутке от M до N.");

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

if (m <= 0 && n <= 0) Console.WriteLine("Введенные числа должны быть положительными!");
else if (m > n)
    Console.WriteLine("Второе число должно быть больше первого!");
else
    Console.WriteLine($"Сумма чисел от {m} до {n} = {GetSum(m, n)}");

int GetSum(int m, int n)
{
    if (m == n) return m;
    return m + GetSum(m + 1, n);
}