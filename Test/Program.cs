static bool CheckNum(string num, out int truenumber)
{
    bool result = Int32.TryParse(num, out int intnum);

    if (intnum > 0)
    {
        truenumber = intnum;
        return result;
    }
    else
    {
        truenumber = 0;
        return result;
    }
        
}

int Number;
string String = Console.ReadLine();

Console.WriteLine(CheckNum(String, out Number));
Console.WriteLine(Number);
