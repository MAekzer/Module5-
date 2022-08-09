static int PowerUp(int N, int pow)
{
    if (pow == 0)
    {
        return 1;
    }
    else if (pow == 1)
    {
        return N;
    }
    else
    {
        return N * PowerUp(N, pow - 1);
    }
}

int n = Convert.ToInt32(Console.ReadLine());
int p = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerUp(n, p));
