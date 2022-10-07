Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int lastnum = (num % 10);
Console.WriteLine("Третья цифра данного числа: " +lastnum);
