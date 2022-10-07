Console.Write("Введите  число:  ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число для проверки кратности:  ");
int provernum = int.Parse(Console.ReadLine() ?? "0");

if (num % provernum == 0)
{
    Console.Write("Данное число кратно заданному");
}
else
{
    int num1 = num % provernum;
    Console.Write("Данное число  не кратно заданному. Остаток будет равен:  "+num1);

}