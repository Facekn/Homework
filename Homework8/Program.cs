Console.Write("Введите трёхзначное число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = (num1 % 100);
int num3 = (num2 / 10);
Console.WriteLine("Вторая цифра данного числа: " +num3);