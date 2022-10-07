Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num == 1)
{
    Console.WriteLine("Сегодня Понедельник");
}
 else if (num == 2)
{
    Console.WriteLine("Сегодня Вторник");
}
else if (num == 3)
{
    Console.WriteLine("Сегодня Среда");
}
else if (num == 4)
{
    Console.WriteLine("Сегодня Четверг");
}
else if (num == 5)
{
    Console.WriteLine("Сегодня Пятница");
}
else if (num == 6)
{
    Console.WriteLine("Сегодня Суббота");
}
else if (num == 7)
{
    Console.WriteLine("Сегодня Воскресенье");
}
else 
{
    Console.WriteLine("Такого дня недели не существует");
}
