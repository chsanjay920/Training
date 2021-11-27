class myParent
{

}
class myChild : myParent
{
	
}

class objectNameOfChild{

	public static void Main()
	{
		myParent p = new myChild();
		System.Console.WriteLine(p);
	}
}