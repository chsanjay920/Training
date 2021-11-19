
class List{
	private int []x;
	private int index=0;
	private int flag=0;
	public void Allocate()
	{
		x = new int[5];
		flag = 1;
	}
	public void add(int k)
	{
		if(flag == 0)
			Allocate();
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
		l.add(100);
		l.add(200);
		l.add(300);
		l.add(400);
		l.add(500);
		l.show();
	}
}