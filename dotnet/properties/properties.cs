class product
{
	private int _pid;
	private string _pname;
	public int pid
	{
		get{
			return _pid;
		}
		set{
			_pid = value;
		}
	}
	public string pname
	{
		get{
			return _pname;
		}
		set{
			_pname = value;
		}
	}
}
class properties
{
	public static void Main()
	{
		product p = new product();
		p.pid = 100;
		p.pname = "sanjay";
		System.Console.WriteLine("{0},{1}",p.pid,p.pname);
	}
}