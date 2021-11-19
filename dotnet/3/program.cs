
class Student{
	private int sno;
	private string sname;
	private double sfee;
	public void ReadName()
	{
		System.Console.Write("Enter stu id : ");
		sno = int.Parse(System.Console.ReadLine());
		System.Console.Write("Enter stu name : ");
		sname = System.Console.ReadLine();
		System.Console.Write("Enter stu fees : ");
		sfee = double.Parse(System.Console.ReadLine());
	}
	public void PrintName()
	{
		System.Console.WriteLine(sno);
		System.Console.WriteLine(sname);
		System.Console.WriteLine(sfee);
	}
	public int getName()
	{
		return sno;
	}
}
class classes{
	public static void Main()
	{
		Student []s;
		int i;
		s = new Student[5];
		for(i=0;i<s.Length;i++)
		{
			s[i] = new Student();
			s[i].ReadName();
		}
		System.Console.WriteLine("Enter sno : ");
		int key = int.Parse(System.Console.ReadLine());
		for(i=0;i<s.Length;i++)
		{
			if(key == s[i].getName())
			{
				s[i].PrintName();
				break;
			}
		}
		if(i == s.Length)
			System.Console.WriteLine("value not found");
	}
}