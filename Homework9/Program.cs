Console.WriteLine("Введите число из диапазона 10 - 99:");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num >= 10 && num <= 99)
{
    int a = num / 10;
    int b = num % 10;
    int max = a;
    
     if (a > b)
    {
        max=a;
        Console.WriteLine("Наибольшая цифра в числе "+num+ " - " +max);
    }

    else if (a < b)
        {
            max = b;
            Console.WriteLine("Наибольшая цифра в числе "+num+ " - " +max);
        }

        else
        {
          Console.WriteLine("Цифры в числе равны");  
        }
}

else
{
    Console.WriteLine("Число не в диапазоне ");
}