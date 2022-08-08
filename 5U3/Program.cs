static void GetName(string name)
{
    Console.WriteLine("Введите имя");
    name = Console.ReadLine();

}

string name = Console.ReadLine();

GetName(name);
Console.WriteLine(name);
