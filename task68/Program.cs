Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int AckermannFunction(int m, int n)
{
    int res = 0;
    if (m == 0)
    {
        res = n+1;
        return res;
    }
    else if (m > 0 && n == 0)
    {
        res = AckermannFunction(m -1, 1);
        return res;
    }
    else if (m > 0 && n > 0)
    {
        res = AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        return res;
    }
    return res;
}
int result = AckermannFunction(m,n);
Console.WriteLine(result);