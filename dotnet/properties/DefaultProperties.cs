class List
{
	private int []x;
	public List()
	{
		x = new int[10];
	}
	public int this[int index]
	{
		set{
			x[index] = value;
		}	
		get{
			return x[index];
		}
	}
}
class program
{
	public static void Main()
	{
		List l = new List();
		l[0] = 100;
		l[1] = 200;
		l[2] = 300;
		for(int i = 0;i<3;i++)
		{
			System.Console.WriteLine(l[i]);
		}
	}
}










