class copyarrayfunction
{
	static void copy(int []arr1,int []arr2)
	{
		for(int i=0;i<arr1.Length;i++)
		arr2[i] = arr1[i];
	}
	public static void Main()
	{
		int []x,y;
		int n = 5;
		x = new int[n];
		y = new int[n];
		for(int i=0;i<n;i++)
		x[i] = int.Parse(System.Console.ReadLine());
		copy(x,y);
		for(int i=0;i<y.Length;i++)
		System.Console.WriteLine(y[i]);
	}
}