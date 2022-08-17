class Triangle
{
    public int A;
    public int B;
    public int C;

    public double S()
    {
        double p = (A + B + C) / 2;
        double s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        return s;
    }

    public int P()
    {
        return A + B + C;
    }
}

class Square
{
    public int A;

    public int S()
    {
        return Convert.ToInt32(Math.Pow(A, 2));
    }

    public int P()
    {
        return A * 4;
    }
}

class Circle
{
    public double R;

    public double S()
    {
        return R * R * 3.14;
    }

    public double P()
    {
        return R * 2 * 3.14;
    }
}
