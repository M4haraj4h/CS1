int[] a=new int[3];
int max = 0;

for(int i = 0;i<a.Length;i++)
{
    a[i]= Convert.ToInt32(Console.ReadLine());
}

for(int i = 0;i<a.Length;i++)
{
    if(a[i]>max)
        {
            max = a[i];
            i++;
        }
    else
        i++;
}

Console.WriteLine("Наибольшее число: ");
Console.WriteLine($"{max}");