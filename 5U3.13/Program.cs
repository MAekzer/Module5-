static int[] GetArray(int num)
{
	var array = new int[num];

	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine("Введите элемент массива номер {0}", array[i] + 1);
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}

static int[] SortArrayAsc(int[] input)
{
	int temp;
    int[] array = new int[input.Length];
	Array.Copy(input, array, input.Length);

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

static int[] SortArrayDesc(int[] input)
{
	int temp;
	int[] array = new int[input.Length];
	Array.Copy(input, array, input.Length);

	for (int i = 0; i < array.Length; i++)
	{
		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] >= array[i])
			{
				temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
		}
	}

	return array;
}

static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
{
	sorteddesc = SortArrayDesc(array);
	sortedasc = SortArrayAsc(array);
}

int[] myarray = GetArray(Convert.ToInt32(Console.ReadLine()));
int[] sortedAsc;
int[] sortedDesc;

SortArray(myarray, out sortedAsc, out sortedDesc);

foreach (int item in sortedAsc)
{
	Console.Write(item + " ");
}

Console.WriteLine();

foreach (int item in sortedDesc)
{
	Console.Write(item + " ");
}

