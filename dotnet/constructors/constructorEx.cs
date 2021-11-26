class Myclass{
  	public Myclass(){
		System.Console.WriteLine("from constructor without parameter");
	} 
	public Myclass(string s){
		System.Console.WriteLine("from constructor with parameter {0}",s);
	} 
}
class constructor{
	public static void Main()
	{
		Myclass m = new Myclass();
		m = new Myclass("hello");
	}
}