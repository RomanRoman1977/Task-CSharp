Console.Write("Введите значение: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Значение четное");
}
else
{
    Console.WriteLine($"Значение не четное");
}
