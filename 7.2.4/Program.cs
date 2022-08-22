class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
    }
}

class DerivedClass : BaseClass
{
    private int counter;

    public override int Counter
    {
        get
        {
            return counter;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Счетчик не может принимать значения меньше нуля");
            else
                counter = value;
        }
    }
}
