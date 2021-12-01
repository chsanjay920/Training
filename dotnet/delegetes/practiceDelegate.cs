namespace n1
{
	delegate void mydelegate();
	class Student
	{
		private int sno;
		private string sname;
		public void Read()
		{
			sno = int.Parse(System.Console.ReadLine());
			sname = System.Console.ReadLine();
		}
		public void Print()
		{
			System.Console.WriteLine("{0} , {1}",sno,sname);
		}
	}

class program
{
	public static void Main()
	{
		mydelegate md = null;
		Student []s;
		s = new Student[5];
		for(int i=0;i<s.Length;i++)
		{
			s[i] = new Student();
			md += new mydelegate(s[i].Read);
		}
		for(int i=0;i<s.Length;i++)
		{
			md += new mydelegate(s[i].Print);
		}
		md();
	}
}
}