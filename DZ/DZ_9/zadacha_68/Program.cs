Console.WriteLine("Программа, которая вычисляет функцию Аккермана с помощью рекурсии для неотрицательных чисел m и n.");

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}
Console.WriteLine(AkkermanFunction(m, n));
