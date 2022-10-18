Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine()!);

int SecondDigit()
{
    int secondDigit = number / 10 % 10;
    return secondDigit;
}

Console.WriteLine(SecondDigit());