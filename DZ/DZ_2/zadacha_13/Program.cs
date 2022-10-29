Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int ThirdDigit()
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    if (number <= 1000 && number >= 100)
    {
        number = number % 10;
    }

    else
    {
        Console.Write("Третьей цифры нет в числе ");
    }
    return number;
}

Console.WriteLine(ThirdDigit());
