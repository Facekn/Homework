Console.Write("Введите трёхзначное число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
if (num1 > -1000 && num1 < -99 || num1>99 && num1 < 1000)
{
    int num2 = (num1 % 100);
    int num3 = (num2 / 10);
    Console.WriteLine("Вторая цифра данного числа: " +num3);
}
else
{
    Console.WriteLine("Данное число не является трёхзначным");   
}