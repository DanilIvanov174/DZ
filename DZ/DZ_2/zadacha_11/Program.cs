// Напишите программу, которая принимает на вход целое число любой 
// разрядности число и удаляет вторую цифру слева направо этого числа.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

int oldnumber = number;
int newnumber = 0;
int newnumber2 = 0;



while(oldnumber > 10)
{
    int oldnumber2 = oldnumber % 10;
    newnumber = newnumber * 10 + oldnumber2;
    oldnumber = oldnumber / 10;
}

newnumber = newnumber / 10;

while (number > 10)
{
    number = number / 10;
}   
newnumber = newnumber * 10 + number;

while (newnumber > 0)
{
    int number3 = newnumber % 10;
    newnumber2 = newnumber2 * 10  + number3;
    newnumber = newnumber / 10;
}

Console.WriteLine(newnumber2);
