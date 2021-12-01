interface IIterator{
	bool HasNext();
	int Next();
	void reInitilize();
}			
class LinkedList : IIterator
{
	int data;
	LinkedList next;
	LinkedList first,prev,temp,NewNode,temp1;
	public LinkedList()
	{
		first = null;
		prev = null;
		temp=first;
	}
	public void add(int x)
	{
		NewNode = new LinkedList();
		NewNode.data = x;
		if(first == null)
		{
			first = NewNode;
			prev = NewNode;
			temp = first;
		}
		else{
			prev.next = NewNode;
			prev = NewNode;
		}
	}
	public bool HasNext()
	{
		temp1 = temp;	
		if(temp != null)
		{
			temp = temp.next;
			return true;
		}
		reInitilize();
		return false;
	}
	public void reInitilize()
	{
		temp = first;
	}
	public int Next()
	{
		return temp1.data;
	}
}

class p{
	public static void Main()
	{
		LinkedList l = new LinkedList();
		IIterator itr;
		l.add(10);
		l.add(20);
		l.add(30);
		itr = l;
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}
		itr = l;
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}	
	}
}

