static (string Name, string LastName, int Age, bool IsPet, int PetCount, string[] PetNames, int NumColors, string[] FavColors) EnterUser()
{
    (string Name, string LastName, int Age, bool IsPet, int PetCount, string[] PetNames, int NumColors, string[] FavColors) User;

    Console.Write("Введите имя: ");
    User.Name = Console.ReadLine();

    Console.Write("Введите фамилию: ");
    User.LastName = Console.ReadLine();

    string Age;

    do
    {
        Console.WriteLine("Сколько вам полных лет?");
        Age = Console.ReadLine();

    } while (CheckNum(Age, out User.Age));

    Console.WriteLine("Есть ли у вас питомец?");
    string temp = Console.ReadLine();
    if (temp == "Yes" | temp == "yes" | temp == "Да" | temp == "да" | temp == "True" | temp == "true")
    {
        User.IsPet = true;
        string PetCount;

        do
        {
            Console.WriteLine("Сколько у вас питомцев?");
            PetCount = Console.ReadLine();

        } while(CheckNum(PetCount, out User.PetCount));

        Console.WriteLine("Введите клички ваших питомцев по очереди:");
        User.PetNames = GetPetsArray(User.PetCount);
    }
    else
    {
        User.IsPet = false;
        User.PetCount = 0;
        User.PetNames = new string[0];
    }

    string Numcolors;

    do
    {
        Console.WriteLine("Сколько у вас любимых цветов?");
        Numcolors = Console.ReadLine();

    } while (CheckNum(Numcolors, out User.NumColors));

    Console.WriteLine("Введите ваши любимые цвета по очереди");
    User.FavColors = GetColorsArray(User.NumColors);

    return User;
}

static string[] GetPetsArray(int num)
{
    string[] array = new string[num];

    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите кличку {0}-го питомца: ", i + 1);
        array[i] = Console.ReadLine();
    }

    return array;
}

static string[] GetColorsArray(int num)
{
    string[] array = new string[num];

    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите {0}-й цвет: ", i + 1);
        array[i] = Console.ReadLine();
    }

    return array;
}

static bool CheckNum(string num, out int number)
{
    Int32.TryParse(num, out int intnum);

    if (intnum > 0)
    {
        number = intnum;
        return false;
    }
    else
    {
        number = 0;
        return true;
    }
}

static void ShowUser()
{
    (string Name, string LastName, int Age, bool IsPet, int PetCount, string[] PetNames, int NumColors, string[] FavColors) User = EnterUser();

    Console.WriteLine();

    Console.WriteLine("Полное имя пользователя: {0} {1}", User.LastName, User.Name);
    Console.WriteLine("Возраст пользователя (полных лет): {0}", User.Age);

    string answer;
    if (User.IsPet)
        answer = "Есть питомцы";
    else
        answer = "Нет питомцев";

    Console.WriteLine("Наличие у пользователя домашних питомцев: {0}", answer);

    if (User.PetCount > 0)
    {
        Console.WriteLine("Количество питомцев у пользователя: {0}", User.PetCount);
        Console.Write("Клички питомцев: {0}", User.PetNames[0]);

        if (User.PetCount > 1)
        {
            for (int i = 1; i < User.PetCount; i++)
            {
                Console.Write(", " + User.PetNames[i]);
            }
        }
        Console.WriteLine(".");
    }

    Console.WriteLine("Количество любимых цветов пользователя: {0}", User.NumColors);

    if (User.NumColors > 1)
    {
        Console.Write("Любимые цвета пользователя: {0}", User.FavColors[0]);
        for (int i = 1; i < User.NumColors; i++)
        {
            Console.Write(", " + User.FavColors[i]);
        }
        Console.WriteLine(".");
    }
    else
    {
        Console.WriteLine("Любимый цвет пользователя: {0}", User.FavColors[0]);
    }
}

ShowUser();

