class Rectangle
{
    public int A;
    public int B;

    public int Square()
    {
        return A * B;
    }

    public Rectangle()
    {
        A = 6;
        B = 4;
    }
    public Rectangle(int a, int b)
    {
        A = a;
        B = b;
    }

    public Rectangle(int a)
    {
        A = B = a;
    }
}