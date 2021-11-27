class Bag
{
	public virtual void Print(){
	}
	public virtual int GetId()
	{
		return 0;
	}
}

class List
{
	int index =0,k=0;
	Bag []x;
	public List()
	{
		x = new Bag[5];
	}
	public List(int n)
	{
		x = new Bag[n];
	}
	public void Add(Bag b)
	{	
		x[index] = b;
		index++;
		k++;
	}
	public Bag Get()
	{
		index--;
		return x[index];
	}
	//swaping 
	public void sort()
	{
		Bag temp;
		for(int i=0;i<k;i++)
		{
			for(int j=i+1;j<k;j++)
			{
				if(x[i].GetId() > x[j].GetId())
				{	
					temp = x[i];
					x[i] = x[j];
					x[j] = temp;
				}
			}
		}
	}
	public void printing()
	{
		for(int j=0;j<k;j++)
		{
			System.Console.ReadLine(x[j].GetId());	
		}
	}
}

class Product : Bag
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
	public override int GetId()
	{
		return pid;
	}
}

class Student : Bag
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
	public override int GetId()
	{
		return sid;
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
		l.sort();
	}
}

	







