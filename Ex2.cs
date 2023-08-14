Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine($"Наибольшее число: {a}");
    Console.WriteLine($"Наименьшее число: {b}");
}
else if (a<b)
{
    Console.WriteLine($"Наибольшее число: {b}");
    Console.WriteLine($"Наименьшее число: {a}");
}
else if (a==b)
{
    Console.WriteLine("Числа одинаковы");
}