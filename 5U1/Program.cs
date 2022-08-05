static string Scan() => Console.ReadLine();

static string ShowColor()
{
	Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
	var color = Scan();

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

static int[] Sort()
{
	var result = new int[5];
	var temp = 0;

	for (int i = 0; i < result.Length; i++)
    {
		Console.WriteLine("Введите элемент массива номер {0}", i + 1);
		result[i] = int.Parse(Scan());
    }

	Console.WriteLine();

	for (int i = 0; i < result.Length; i++)
	{
		for (int j = i + 1; j < result.Length; j++)
		{
			if (result[j] <= result[i])
			{
				temp = result[i];
				result[i] = result[j];
				result[j] = temp;
			}
		}
	}


	foreach (var item in result)
    {
		Console.WriteLine(item);
    }

	return result;
}

Sort();
