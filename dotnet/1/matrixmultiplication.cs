class matrixmultiplication{
	public static void Main()
	{
		System.Console.Write("1st matrix rows : ");
		int row = int.Parse(System.Console.ReadLine());
		System.Console.Write("1st matrix columns : ");
		int column = int.Parse(System.Console.ReadLine());
        
		int [,]x,y;
		x = new int[row,column];		
		for(int i=0;i<row;i++)
		{	
			System.Console.WriteLine("row {0}",i);
			for(int j=0;j<column;j++)
			{
				x[i,j] = int.Parse(System.Console.ReadLine());
			}	
		}

        System.Console.Write("2nd matrix rows : ");
        int row2 = int.Parse(System.Console.ReadLine());
		System.Console.Write("2nd matrix columns : ");
		int column2 = int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Second matrix");
        if(column != row2)
        {
            System.Console.WriteLine("Multiplication not possible");
        }
        y = new int[row2,column2];
		for(int i=0;i<row2;i++)
		{	
			System.Console.WriteLine("row {0}",i);
			for(int j=0;j<column2;j++)
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
		for(int i=0;i<row2;i++)
		{	
			for(int j=0;j<column2;j++)
			{
				System.Console.Write(" {0} ",y[i,j]);
			}
            System.Console.WriteLine("");	
		}

        int [,]res;
        res = new int[row,column2];

		System.Console.WriteLine("result matrix:");
		for(int i=0;i<row;i++)
		{	
			for(int j=0;j<column2;j++)
			{
                for(int k=0;k<column;k++)
			    {
                    res[i,j] = res[i,j]+x[i,k]*y[k,j];
                }
				System.Console.Write(" {0} ",res[i,j]);
			}	
            System.Console.WriteLine("");	
		}
	}
}