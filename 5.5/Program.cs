static void Echo(string saidworld, int deep)
{
    string modif = saidworld;

    if (modif.Length > 2)
    {
        modif = modif.Remove(0, 2);
    }
    Console.WriteLine("..." + modif);

    if (deep > 1)
    {
        Echo(modif, deep - 1);
    }
}

Console.WriteLine("Скажите что-нибудь");
var phrase = Console.ReadLine();

Console.WriteLine("Задайте частоту эхо");
var deep = Convert.ToInt32(Console.ReadLine());

Echo(phrase, deep);
