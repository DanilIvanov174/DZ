Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите число k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите число k2");
double k2 = double.Parse(Console.ReadLine()!);

double x = Math.Round(((-b2 + b1) / (-k1 + k2)), 1);
double y = Math.Round((k2 * x + b2), 1);

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x} Y: {y}");
