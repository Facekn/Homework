Console.Write("Введите последнее число диапозона: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int a = 1;
for (int i = a; i<=b; i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}