Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num < 0)
{
    num = -num;
}

if (num > 100)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine("Третья цифра числа: " + result );
}
else
{
    Console.WriteLine("Цифры с номером 3 нет в числе " +num);
}