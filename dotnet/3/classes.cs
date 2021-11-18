
class Student{
	private string sname;
	public void ReadName()
	{
		sname = System.Console.ReadLine();
	}
	public void PrintName()
	{
		System.Console.WriteLine(sname);
	}
}
class classes{
	public static void Main()
	{
		Student []s;
		s = new Student[5];
		for(int i=0;i<s.Length;i++)
		{
			s[i] = new Student();
			s[i].ReadName();
		}
		for(int i=0;i<s.Length;i++)
		{
			s[i].PrintName();
		}
		
	}
}