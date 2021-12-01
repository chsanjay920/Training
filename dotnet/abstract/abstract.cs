abstract class myClass{
	public abstract int sum(int a,int y);
	public int subtract(int x,int y)
	{
		return (x-y);
	}
}
class Math : myClass{
	public override int sum(int x,int y)
	{
		return x+y;
	}
	public int multiply(int x,int y)
	{
		return x*y;
	}
}
class abstractclass{
	public static void Main()
	{
		//myClass m;
		Math m = new Math();
		System.Console.WriteLine(m.subtract(100,20));
		System.Console.WriteLine(m.sum(100,200));
		System.Console.WriteLine(m.multiply(5,10));
	}
}