class List{
	int []x;
  	public List(){
		x = new int[5];
	} 
	public List(int val){
		x = new int[val];
	} 
	public void Read()
	{
		for(int i=0;i<x.Length;i++)
		 	x[i] = int.Parse(System.Console.ReadLine());
	}
	public void Print()
	{
		for(int i=0;i<x.Length;i++)
			System.Console.WriteLine(x[i]);
	}
}
class ConstructorEx2{
	public static void Main()
	{
		List l = new List(10);
		l.Read();
		l.Print();
	}
}