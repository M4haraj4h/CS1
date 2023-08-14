Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

List<int> all = new List<int>();

int n = 0;

while (n<a-1)
{
    n = n + 2;
    all.Add(n);
}
all.ForEach(Console.WriteLine);