class MyClass{
	public MyClass()
	{
		System.Console.WriteLine("with out parameter constructor");
	}
	public MyClass(string s)
	{
		System.Console.WriteLine("with parameter constructor {0}",s);
	}
}
class constructorOverloading{
	public static void Main()
	{
		MyClass m = new MyClass("hello");
	}
}