Console.WriteLine("ВВедите число a");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите число b");
int b = int.Parse(Console.ReadLine()!);

if (a < b)
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}
else
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}