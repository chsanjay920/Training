class Math2020
{
	public int sum(int x,int y)
	{
		return (x+y);
	}
	protected int subt(int x,int y)
	{
		return (x-y);
	}
}
class Math2021 : Math2020
{
	public int mult(int x,int y)
	{
		return (x*y);
	}
	public int subtract(int x,int y)
	{
		return (subt(x,y));
	}
}
class program{
	public static void Main()
	{
		Math2020 M2020;
		Math2021 M2021;
		M2020 = new Math2020();
		M2021 = new Math2021();
		System.Console.WriteLine(M2020.sum(200,300));
		System.Console.WriteLine(M2021.sum(200,300));
		System.Console.WriteLine(M2021.mult(200,300));
		System.Console.WriteLine(M2021.subtract(200,300));
		
	}
}

