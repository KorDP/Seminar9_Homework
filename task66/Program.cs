Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumElement(int m1, int n1)
{
    int result = 0;
    if (n1 == m1)
    {
        return result + m1;
    }
    if (m1 > n1)
    {
        result += SumElement(m1 - 1, n1);
    }
    else
    {
        result += SumElement(m1 + 1, n1);
    }
    return result += m1;
}

int res = SumElement(m, n);
Console.WriteLine(res);