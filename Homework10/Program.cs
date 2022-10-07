Console.Write("Введите трёхзначное число:  ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num > -1000 && num < -99 || num>99 && num < 1000)
{
    int num1 = num / 100;
    int num2 = num % 10;
    int result = num1*10 + num2;
    Console.Write("Итоговый результат:  " +result);
}
else
{
    Console.WriteLine("Данное число не является трёхзначным");   
}
