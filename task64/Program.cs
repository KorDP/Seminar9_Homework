Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturanNumsToN(int num)
{
    if (num == 1)
    {
        Console.Write($"{num} ");
        return;
    }
    if (n > 1)
    {
        Console.Write($"{num}, ");
        NaturanNumsToN(num - 1);
    }
    else
    {
        Console.Write($"{num}, ");
        NaturanNumsToN(num + 1);
    }
}

NaturanNumsToN(n);