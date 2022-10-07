Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int c = b*b;
if (a == c)
{
    Console.Write("Число A является квадратом B!");
}
else 
{
    Console.Write("Число A не является квадратом B!");
}
