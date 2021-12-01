namespace nm
{
	public delegate int mydelegete(int x,int y);
	public class Math
	{
		public int sum(int x,int y)
		{
			return (x+y);
		}
		public int subt(int x,int y)
		{
			return (x-y);
		}
		public int multiply(int x,int y)
		{
			return (x*y);
		}
	}
	public class program
	{
		public static void Main()
		{
			mydelegete md;
			Math m = new Math();
			md = new mydelegete(m.sum);
			System.Console.WriteLine(md(100,200));
			System.Console.WriteLine(md.Invoke(200,300));
			md = new mydelegete(m.subt);
			System.Console.WriteLine(md(50,10));
		}		
	}
}