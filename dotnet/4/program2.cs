
class List{
	private int []x;
	private int index;
	private int flag;
	public void initialize()
	{
		index=0;
		flag=0;
		x = new int[5];
	}
	public void initialize(int n)
	{
		x = new int[n];
	}
	public void add(int k)
	{
		x[index] = k;
		index += 1;
	}
	public void show()
	{	
		for(int i=0;i<x.Length;i++)
		System.Console.WriteLine(x[i]);
	}
}
class classes{
	public static void Main()
	{
		List l = new List();
		System.Console.Write("Enter size of array : );
		int n = int.Parse(System.Console.ReadLine());
		if(n > 0)
			l.initialize(n);
		else
			l.initialize();
		for(int i=0;i<n;i++)
			add(int.Parse(System.Console.ReadLine()));
		l.show();
	}
}