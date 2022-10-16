Console.WriteLine("ВВедите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите третье число");
int c = int.Parse(Console.ReadLine()!);
int max = 0;

if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("max = " + max);