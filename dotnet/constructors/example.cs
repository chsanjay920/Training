class Math{
	private int data;
	public Math(int val)
	{
		data = val;	
	}
	public Math Sum(Math M)
	{
		//Math temp;
		/*temp = new Math(data+M.data)*/
		/*
		temp = new Math();
		temp.data = data+M.data
		*/
		return (new Math(data+M.data));
	}
	public void print()
	{
		System.Console.WriteLine(data);
	}
}
class Program{
	public static void Main()
	{
		Math m1,m2,m3;
		m1 = new Math(100);
		m2 = new Math(200);
		m3 = m1.Sum(m2);
		m3.print();
	}
}




