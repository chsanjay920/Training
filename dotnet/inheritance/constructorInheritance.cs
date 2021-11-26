class Base{
	public Base()
	{
		System.Console.WriteLine("from base constructor");
	}
}
class child : Base
{
	public child()
	{
		System.Console.WriteLine("from chile costructor");
	}
}
class Myclass{
	public static void Main()
	{
		Base b = new Base();
		child c = new child();
	}
}