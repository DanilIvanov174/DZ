Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

void ThirdDigit()
{
    while (number >= 1000)
        number = number / 10;

    if (number <= 1000 && number >= 100)
    {
        number = number % 10;
        Console.Write(number);
    }
    
    else
        Console.Write("Третьей цифры нет в числе ");
}
ThirdDigit();