class doubleDimeArray{
	public static void Main()
	{
		System.Console.Write("Enter matrix rows : ");
		int row = int.Parse(System.Console.ReadLine());
		System.Console.Write("Enter matrix columns : ");
		int column = int.Parse(System.Console.ReadLine());
		int [,]x,y;
		x = new int[row,column];
		y = new int[row,column];		
		for(int i=0;i<row;i++)
		{	
			System.Console.WriteLine("row {0}",i);
			for(int j=0;j<column;j++)
			{
				x[i,j] = int.Parse(System.Console.ReadLine());
			}	
		}
		System.Console.WriteLine("Second matrix");
		for(int i=0;i<row;i++)
		{	
			System.Console.WriteLine("row {0}",i);
			for(int j=0;j<column;j++)
			{
				y[i,j] = int.Parse(System.Console.ReadLine());
			}	
		}
		System.Console.WriteLine("1st matrix:");
		for(int i=0;i<row;i++)
		{	
			for(int j=0;j<column;j++)
			{
				System.Console.Write(" {0} ",x[i,j]);
			}	System.Console.WriteLine("");	
		}
		System.Console.WriteLine("2nd matrix:");
		for(int i=0;i<row;i++)
		{	
			for(int j=0;j<column;j++)
			{
				System.Console.Write(" {0} ",y[i,j]);
			}System.Console.WriteLine("");	
		}
		System.Console.WriteLine("result matrix:");
		for(int i=0;i<row;i++)
		{	
			for(int j=0;j<column;j++)
			{
				System.Console.Write(" {0} ",x[i,j]+y[i,j]);
			}	System.Console.WriteLine("");	
		}
	}
}