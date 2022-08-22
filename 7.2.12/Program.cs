class Obj
{
    public int Value;

    public static Obj operator + (Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value + b.Value,
        };
    }

    public static Obj operator - (Obj a, Obj b)
    {
        return new Obj { Value = a.Value - b.Value };
    }
}
