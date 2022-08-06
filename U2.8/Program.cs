static string Scan() => Console.ReadLine();

static int[] GetArray()
{
	var array = new int[5];
	for (int i = 0; i < array.Length; i++)
    {
		Console.WriteLine("Введите элемент массива номер {0}", array[i] + 1);
		array[i] = int.Parse(Console.ReadLine());
    }
	return array;
}

static int[] SortArray(int[] array)
{
	var temp = 0;

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

var arr = SortArray(GetArray());

foreach (int item in arr)
{
	Console.Write(item + " ");
}