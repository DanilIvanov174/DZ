Console.WriteLine("Программа, которая выводит все натуральные числа в промежутке от N до 1");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int endValue = 1;

if (n < 0) Console.WriteLine("Некорректный ввод, введите натуральное число.");
else NumbersFromNToOne(n, endValue);

void NumbersFromNToOne(int n, int endValue)
{
    if (endValue < n)
    {
        NumbersFromNToOne(n, endValue + 1);
    }
    if (endValue > 1) Console.Write(endValue + ", ");
    else Console.Write(endValue);
}