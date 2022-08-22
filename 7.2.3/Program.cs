class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}
class DerivedClass : BaseClass
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass baseclass = new BaseClass();
        DerivedClass derivedclass = new DerivedClass();

        baseclass.Display();
        derivedclass.Display();
        ((BaseClass)derivedclass).Display();

        BaseClass newclass = new DerivedClass();
        DerivedClass derivedclass2 = (DerivedClass)newclass;
        newclass.Display();
        derivedclass2.Display();
        
    }
}

