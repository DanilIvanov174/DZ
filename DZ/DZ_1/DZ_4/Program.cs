Console.WriteLine("ВВедите число");
int a = int.Parse(Console.ReadLine()!);
int b = 2;
if(a>0)
{
    while (b < a)
    {
        Console.WriteLine(b + " ");
        b = b + 2;
    }
}
else
{
    Console.WriteLine("Необходимо ввести положительное число");
}