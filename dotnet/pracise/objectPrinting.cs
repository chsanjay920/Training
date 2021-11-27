class sanjay
{
	public void print()
	{
		System.Console.WriteLine("hello ");
	}
}
class objectPrinting{
	public static void Main()
	{
		sanjay s = new sanjay();
		//System.Console.WriteLine(s.GetHashCode());
		System.Console.WriteLine(" object name : "+s.ToString());
	}	
}