class MyBase
{
	public MyBase(int val)
	{
		System.Console.WriteLine("from base constructor {0}",val);
	}
}
class MyChild : MyBase
{
	public MyChild(int val) : base(val)
	{
		System.Console.WriteLine("from child constructor {0}",val);
	}
}
class program{
	public static void Main()
	{
		MyBase b = new MyBase(100);
		MyChild c = new MyChild(200);
	}
}