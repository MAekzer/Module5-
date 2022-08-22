class Obj
{
	private string name;
	private string owner;
	private int length;
	private int count;

	public Obj(string name, string ownerName, int objLength, int count)
	{
		this.name = name;
		owner = ownerName;
		length = objLength;
		this.count = count;
	}
}

class BaseClass
{
	protected string Name;

	public BaseClass(string name)
	{
		Name = name;
	}
}

class DerivedClass : BaseClass
{
	public string Description;

	public int Counter;

	public DerivedClass(string name, string description, int counter) : base(name)
    {
        Description = description;
        Counter = counter;
    }

	public DerivedClass(string name, string description) : base(name)
    {
		Description = description;
    }
}
