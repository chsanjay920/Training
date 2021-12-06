
class student
{
	private int sno;
	private string sname;
	public void Read()
	{
		sno = int.Parse(System.Console.ReadLine());
		sname = System.Console.ReadLine();
	}
	public override string ToString()
	{
		return (sno+"  "+sname);
	}
}

class objectNameOfChild{

	public static void Main()
	{
		object o = new student();
		((student)o).Read();
		System.Console.WriteLine(o);
	}
}