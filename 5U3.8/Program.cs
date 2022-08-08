static int[] GetArray(out int num)
{
	num = Convert.ToInt32(Console.ReadLine());
	var array = new int[num];
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine("Введите элемент массива номер {0}", array[i] + 1);
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}