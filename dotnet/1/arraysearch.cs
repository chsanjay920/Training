class arraysearch{
	public static void Main()
	{
		System.Console.WriteLine("Enter a array size");
		int n = int.Parse(System.Console.ReadLine());
		int []x;
		x = new int[n];
		System.Console.WriteLine("Enter array values");
		for(int i=0;i<x.Length;i++)
		{
			x[i] = int.Parse(System.Console.ReadLine());
		}
		System.Console.WriteLine("Enter a key : ");
		int key = int.Parse(System.Console.ReadLine());
		int flag = 0;
		for(int i=0;i<x.Length;i++)
		{
			if(x[i] == key){
				System.Console.WriteLine("Key is found at : {0}",i);
				flag = 1;
			}
			
		}
		if(flag == 0)
			System.Console.WriteLine("Key not found");
	}
}