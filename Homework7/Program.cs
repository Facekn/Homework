Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num > -1000 && num < -99 || num > 99 && num < 1000)
{
    int lastnum = (num % 10);
    Console.WriteLine("Третья цифра данного числа: " +lastnum);
}

else
{
    Console.WriteLine("Данное число не является трёхзначным");   
}