//binding

class parent
{
	public virtual void print()
	{
		System.Console.WriteLine("from parent print");
	}
}
class child : parent
{
	public override void print()
	{
		System.Console.WriteLine("from child print");
	}
}
class program
{
	public static void Main()
	{
		parent p = new parent();
		p.print();
		p = new child();
		p.print();
	}
}




