Console.WriteLine("Введите число от 1 до 7");
int number = int.Parse(Console.ReadLine()!);

void Weekend()
{
if (number < 1 || number > 7)
{
    Console.WriteLine("Число не в диапазоне от 1 до 7");
}
if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
}

Weekend();