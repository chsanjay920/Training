abstract class math{
	
	public math(){
		System.Console.WriteLine("h from math con");
	}
	public abstract int sum(int x,int y);
}
class math2 : math{
	public math2(){
		system.Console.WriteLine("h from math con");
	}
	public override int sum(int x,int y){
		return x+y;
	}
}
class abstractClassConstructor{
	math2 m = new math2();	
}