static int[] GetArray(int num = 5)
{
	var array = new int[num];
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine("Введите элемент массива номер {0}", array[i] + 1);
		array[i] = int.Parse(Console.ReadLine());
	}
	return array;
}

static int[] SortArray(int[] array)
{
	int temp;

	for (int i = 0; i < array.Length; i++)
	{
		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] <= array[i])
			{
				temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
		}
	}

	return array;
}

static void ShowArray(int[] array, bool IsSort = false)
{
	var newarray = array;

	if (IsSort == true)
    {
		newarray = SortArray(array);
    }

	foreach (int item in newarray)
	{
		Console.Write(item + " ");
	}
}

var array = GetArray(10);
ShowArray(array, true);
