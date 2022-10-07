Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num % 2 == 1)
{
    Console.WriteLine("Число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}
