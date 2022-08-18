class User
{
	private int age;
	private string mail;
	private string username;

	public string Username
    {
		get
        {
			return username;
        }

		set
        {
			if (value.Length >= 3)
				username = value;
			else
				Console.WriteLine("Логин должен содержать не менее трех символов");

        }
    }

	public string Mail
    {
		get
        {
			return mail;
        }

		set
        {
			if (value.Contains("@"))
				mail = value;
			else
				Console.WriteLine("Некорректный формат почты");
        }
	}

	public int Age
	{
		get
		{
			return age;
		}

		set
		{
			age = value;
		}
	}
}
