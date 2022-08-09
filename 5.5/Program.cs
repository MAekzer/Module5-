static void Echo(string saidworld, int deep)
{
    string modif = saidworld;

    if (modif.Length > 2)
    {
        modif = modif.Remove(0, 2);
    }

    ConsoleColor color = (ConsoleColor)deep;
    Console.BackgroundColor = color;

    Console.WriteLine("..." + modif);

    if (deep > 1)
    {
        Echo(modif, deep - 1);
    }
}

static decimal Factorial(int num)
{
    if (num == 0)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(number));

Console.WriteLine("Скажите что-нибудь");
var phrase = Console.ReadLine();

Console.WriteLine("Задайте частоту эхо");
var deep = Convert.ToInt32(Console.ReadLine());

Echo(phrase, deep);
