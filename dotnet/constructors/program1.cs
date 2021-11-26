class product{
	private int pid;
	private string pname;
	private double prize;
	public product(int a,string b,double c)
	{
		pid = a;
		pname = b;
		prize = c;
	}
	public void print()
	{
		System.Console.WriteLine("pid : {0}, pname : {1}, prize : {2}",pid,pname,prize);
	}	
	public int getId()
	{
		return pid;
	}
}
class List
{
	int index =0,len=0;
	product []x;
	public List()
	{
		x = new product[5];
	}
	public List(int a)
	{
		x = new product[a];
	}
	public void add(product p)
	{
		x[index] = p;
		index += 1;
		len = len + 1;
	}
	public product get()
	{
		index -= 1;
		return x[index];
	}
	public product find(int key)
	{
		for(int i=0;i<len;i++)
		{
			if(x[i].getId() == key)
			{
				return x[i];
			}
		}
		return null;
	}
}
class program1{
	public static void Main()
	{
		List l = new List(10);
		product p1 = new product(1,"sanjay1",45);
		product p2 = new product(2,"sanjay2",55);
		product p3 = new product(3,"sanjay3",65);
		l.add(p1);
		l.add(p2);
		l.add(p3);
		for(int i=0;i<3;i++)
		{
			product p = l.get();
			p.print();
		}
		product k = l.find(0);
		if(k != null)
		{
			k.print();
		}
		else
			System.Console.WriteLine("Data not found");
	}	
}














