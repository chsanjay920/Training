class List
{
	private int index=0;
	private object []x;
	public List()
	{
		x = new object[5];
	}
	public List(int n)
	{
		x = new object[n];
	}
	public void Add(object s)
	{	
		x[index] = s;
		index++; 
	}
	public string Find(object n)
	{
		for(int i=0;i<index;i++)
		{
			if(x[i].Equals(n))
			{
					return x[i].ToString();
			}
		}
		return "data not found";
	}
}

class Product
{
	private int pid;
	private string pname;
	public void Read()
	{
		System.Console.WriteLine("Enter pid pname");
		pid = int.Parse(System.Console.ReadLine());
		pname =System.Console.ReadLine();
	}
	public override bool Equals(object n)
	{
		if(this.pid == ((int)n))
			return true;
		return false;
	}
	public override string ToString()
	{
		return (this.pid+" "+this.pname+"");
	}
}

class Student
{
	private int sid;
	private string sname;
	public void Read()
	{
		System.Console.WriteLine("Enter sid sname");
		sid = int.Parse(System.Console.ReadLine());
		sname =System.Console.ReadLine();
	}
	public override bool Equals(object n)
	{
		if(this.sid == ((int)n))
			return true;
		return false;
	}
	public override string ToString()
	{
		return (this.sid+" "+this.sname+"");
	}
}

class program {
	public static void Main()	
	{
		Product p1 = new Product();
		Student s1 = new Student();
		List l = new List(5);
		p1.Read();
		s1.Read();
		l.Add(p1);
		l.Add(s1);
		l.Add(100);
		l.Add(20.52);
		l.Add("sanjay");
		System.Console.WriteLine(l.Find(10));
		
	}
}

	







