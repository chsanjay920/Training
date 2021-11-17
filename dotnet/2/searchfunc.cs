class searchfun{

	static int search(int []x,int p){
		for(int i=0;i<x.Length;i++)
		{
			if(x[i] == p)
				return i;
		}
		return -1;
	
	}
	public static void Main()
	{
		System.Console.WriteLine("Enter size of arr: ");
		int n = int.Parse(System.Console.ReadLine());
		int []x = new int[n];
		System.Console.WriteLine("Enter array values: ");
		for(int i=0;i<x.Length;i++)
		{
			x[i] = int.Parse(System.Console.ReadLine());
		}
		System.Console.WriteLine("Enter key values: ");
		int key = int.Parse(System.Console.ReadLine());
		int pos = search(x,key);
		if(pos != -1)
		System.Console.WriteLine(pos);
		else
		System.Console.WriteLine("Value not found");
	}
}