Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);


int oldValue = number;
int newValue = 0;

while (number > 0)
{
    int number2 = number % 10;
    newValue = newValue * 10 + number2;
    number = number / 10;
}
if (newValue == oldValue)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");


