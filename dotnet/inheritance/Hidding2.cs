class parent{
	public void print()
	{
		System.Console.WriteLine("from parent print");
	}	
}

class child : parent
{
	public new void print()
	{
		System.Console.WriteLine("from child");
		base.print();
	}
}
class program
{
	public static void Main()
	{
		parent p = new parent();
		child c =  new child();
		p.print();
		c.print();
	}
}