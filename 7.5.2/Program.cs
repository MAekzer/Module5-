class Obj
{
    public string Name;
    public string Description;
    public static int MaxValue;
    public static int MinValue;
    public int Value;
    public static string Parent;
    public static int DaysInWeek;

    static Obj()
    {
        MaxValue = 2000;
        MinValue = 0;
        Parent = "System.Object";
        DaysInWeek = 7;
    }
}

class Helper
{
    public static void Swap(ref int num1, ref int num2)
    {
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
    }
}

static class IntExtensions
{
    public static int GetNegative(this int num)
    {
        if (num < 0 || num == 0)
            return num;
        else
            return -num;
    }

    public static int GetPositive(this int num)
    {
        if (num > 0 || num == 0)
            return num;
        else
            return -num;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int number1 = 5;
        int number2 = -7;

        Console.WriteLine(number1.GetNegative());
        Console.WriteLine(number1.GetPositive());

        Console.WriteLine(number2.GetNegative());
        Console.WriteLine(number2.GetPositive());
    }
}
