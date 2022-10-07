Console.Write("Введите последнее число диапозона: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
while (i<=b)
{
    if(i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}