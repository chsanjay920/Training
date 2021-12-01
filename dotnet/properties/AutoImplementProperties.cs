class product
{
	public int pid{get;set;}
	public string pname{get;set;}
}
class program
{

	public static void Main()
	{
		product p = new product();
		p.pid = 100;
		p.pname = "sanjay";
		System.Console.WriteLine("{0},{1}",p.pid,p.pname);
	}
}