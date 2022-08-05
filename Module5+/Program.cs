(string Name, string[] Dishes) User;

Console.Write("Введите имя: ");
User.Name = Console.ReadLine();

Console.WriteLine("Назовите свои любимые блюда");

User.Dishes = new string[5];

for (int i = 1; i <= 5; i++)
{
    Console.Write("Назовите {0}-е блюдо: ", i);
    User.Dishes[i - 1] = Console.ReadLine();
}

Console.Write(User.Name + " ");
for (int i = 0; i < User.Dishes.Length; i++)
{
    Console.Write(User.Dishes[i] + " ");
}