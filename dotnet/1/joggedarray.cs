class joggedarray{
	public static void Main()
	{
		int [][]x;
		x = new int[100][];
		for(int i=0;i<100;i++)
		{
			x[i] = new int[i+1];
			for(int j=0;j<=i;j++)
			{
				x[i][j] = j+1;
			}
		}
		for(int i=0;i<100;i++)
		{
			for(int j=0;j<i;j++)
			{
				System.Console.Write(x[i][j]+" ");
			}
			System.Console.WriteLine(" ");
		}
	}
}