Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число C: ");
int c = int.Parse(Console.ReadLine() ?? "0");
int max = a;

if (b>a)
{
    max = b;
}
if (c>max)
{
    max = c; 
}
Console.Write("Наибольшее число = " +max);
