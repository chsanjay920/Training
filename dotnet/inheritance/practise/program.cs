class List
{
	int index =0;
	List []x;
	public List()
	{
		x = new List[5];
	}
	public List(int n)
	{
		x = new List[n];
	}
	public void Add(Product p)
	{	
		x[index] = p;
		index++;
	}
	public void Add(Student s)
	{	
		x[index] = s;
		index++;
	}
	public List Get()
	{
		index--;
		return x[index];
	}
	public virtual void Print(){
	}
}

class Product : List
{
	private int pid;
	private string pname;
	private double price;	
	public void Read()
	{
		System.Console.WriteLine("Enter pid pname prize");
		pid = int.Parse(System.Console.ReadLine());
		pname =System.Console.ReadLine();
		price = double.Parse(System.Console.ReadLine());
	}
	public override void Print()
	{
		System.Console.WriteLine("{0} {1} {2}",pid,pname,price);
	}
}

class Student : List
{
	private int sid;
	private string sname;
	private double fee;	
	public void Read()
	{
		System.Console.WriteLine("Enter sid sname fee");
		sid = int.Parse(System.Console.ReadLine());
		sname =System.Console.ReadLine();
		fee = double.Parse(System.Console.ReadLine());
	}
	public override void Print()
	{
		System.Console.WriteLine("{0} {1} {2}",sid,sname,fee);
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
		for(int i=0;i<2;i++)
		{
			l.Get().Print();
		}
	}
}

	







