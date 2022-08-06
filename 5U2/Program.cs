static string ShowColor(string username, int userage)
{
	Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет", username, userage);

	var color = Console.ReadLine();

	if (color != null)
	{
		switch (color)
		{
			case "red":
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
				break;

			case "green":
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
				break;

			case "blue":
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is blue");
				break;

			case "yellow":
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is yellow");
				break;

			case "cyan":
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is cyan");
				break;

			default:
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.Red;

				Console.WriteLine("Please choose another color! :c");
				break;
		}
		return color;
	}
	return "0";
}

static void ShowFavColors(params string[] favcolors)
{
	Console.WriteLine("Ваши любимые цвета:");
	foreach (var color in favcolors)
	{
		Console.WriteLine(color);
	}
}

(string name, int age) anketa;

Console.Write("Укажите свое имя: ");
anketa.name = Console.ReadLine();
Console.Write("Укажите свой возраст: ");
anketa.age = checked(int.Parse(Console.ReadLine()));

var favcolors = new string[3];

for (int i = 0; i < 3; i++)
{
	favcolors[i] = ShowColor(anketa.name, anketa.age);
}

ShowFavColors();

