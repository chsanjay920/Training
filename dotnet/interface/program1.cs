interface IIterator{
	bool HasNext();
	int Next();
}
class Stack : IIterator
{
	int []stack;
	int index,k;
	public Stack()
	{
		index = 0;
		k = 0;
		stack = new int[10];
	}
	public void push(int x)
	{
		stack[index] = x;
		index++;
		k++;
	}
	public void pop()
	{
		stack[k]=0;
		k = k-1;
	}
	public bool HasNext()
	{
		if(k > 0)
			return true;
		return false;
	}
	public int Next()
	{
		k--;
		return stack[k];
	}
}
class Queue : IIterator
{
	int []queue;
	int index,k;
	public Queue()
	{
		index = 0;
		k = 0;
		queue = new int[10];
	} 
	public void pop()
	{
		queue[k]=0;
		k++;
	}
	public void push(int x)
	{
		queue[index] = x;
		index++;
	}
	public bool HasNext()
	{
		if(k < index)
			return true;
		return false;
	}
	public int Next()
	{
		k++;
		return queue[k-1];
	}
}

class LinkedList : IIterator
{
	public int data;
	public	LinkedList next;
	LinkedList first=null,prev=null,NewNode,temp,temp1;
	public void add(int val)
	{
		NewNode= new LinkedList();
		NewNode.data=val;
		if(first==null)
		{
			first = NewNode;
			prev = NewNode;	
			temp=first;
		}
		else
		{
			prev.next = NewNode;
			prev = NewNode;
		}
	}
	public int Next()
	{
		return temp1.data;
	}
	public bool HasNext()
	{
		temp1=temp;
		if(temp!=null)
		{
			temp=temp.next;
			return true;
		}
		else
		{
			temp=first;
			return false;
		}
	}
}			
class program1{
	public static void Main()
	{
		Stack s = new Stack();
		Queue q = new Queue();
		LinkedList l = new LinkedList();
		IIterator itr;
		s.push(100);
		s.push(200);
		s.push(300);
		//s.pop();
		itr = s;
		System.Console.WriteLine("====stack====");
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}
		q.push(10);
		q.push(20);
		q.push(30);
		//q.pop();
		itr = q;
		System.Console.WriteLine("====queue====");
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}
		l.add(10);
		l.add(20);
		l.add(30);
		itr = l;
		System.Console.WriteLine("====linkedlist====");
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}	
	}
}

