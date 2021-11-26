class Base{
	public Base(int val)
	{
		System.Console.WriteLine("From base {0}",val);
	}
	public Base()
	{
		System.Console.WriteLine("from base without parameter");
	}
}
class child : Base
{
	public child(int val){
		System.Console.WriteLine("from child {0}",val);
	}
}
class MyClass{
	public static void Main()
	{
		Base b = new Base(100);
		child c = new child(200);
	}
}