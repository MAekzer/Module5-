static void GetName(string name)
{
    Console.WriteLine("Введите имя");
    name = Console.ReadLine();

}

var name = Console.ReadLine();
Console.WriteLine(name);

GetName(name);
Console.WriteLine(name);
