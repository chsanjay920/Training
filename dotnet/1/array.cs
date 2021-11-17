class array{
	public static void Main()
	{
		int []x;
		System.Console.WriteLine("Enter a size of array : ");
		int n = int.Parse(System.Console.ReadLine());
		x = new int[n];
		for(int i=0;i<x.Length;i++)
		{	
			System.Console.WriteLine("Enter {0} value",i);
			x[i] = int.Parse(System.Console.ReadLine());
		}
		for(int i=0;i<x.Length;i++)
		{
			System.Console.WriteLine(x[i]);
		}
	}
}