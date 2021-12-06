interface IIterator
{
	bool HasNext();
	int Next();
}

class Stack : IIterator
{
	int []x;
	int top;
	
	public Stack()
	{
		x = new int[10];
		top = -1;
	}

	public void Push(int val)
	{
		x[++top] = val;
	}

	public int Next()
	{
		return x[top--];
	}
		
	public bool HasNext()
	{
		if(top>=0)
		{
			return true;
		}
		return false;
	}
}

class Queue : IIterator
{
	int []x;
	int front,rare;
	
	public Queue()
	{
		x = new int[10];
		front = 0;
		rare = 0;
	}

	public void Enqueue(int val)
	{
		x[front++] = val;
	}

	public int Next()
	{
		return x[rare++];
	}

	public bool HasNext()
	{
		if(rare<front)
		{
			return true;
		}
		return false;
	}
}

class LinkedList : IIterator
{
	int data,temp;
	LinkedList next,nw,prev,first,guest;

	public LinkedList()
	{
		first = null;
	}

	public void Add(int val)
	{
		nw = new LinkedList();
		nw.data = val;
		nw.next = null;
		if(first == null)
		{
			//guest = first = nw;
			first = nw;
		}
		else
		{
			prev.next = nw;
		}
		prev = nw;
	}

	public IIterator GetIterator()
	{
		guest = first;
		return this;
	}

	public int Next()
	{
		temp = guest.data;
		guest = guest.next;
		return temp;
	}

	public bool HasNext()
	{
		if(guest!=null)
		{
			return true;
		}
		//guest = first;
		return false;
	}
}

class Program
{
	public static void Main()
	{
		Stack stk = new Stack();
		Queue q = new Queue();
		LinkedList l = new LinkedList();
		IIterator itr;
		stk.Push(1);	
		stk.Push(2);
		stk.Push(3);
		stk.Push(4);
		q.Enqueue(10);
		q.Enqueue(20);
		q.Enqueue(30);
		q.Enqueue(40);
		l.Add(100);
		l.Add(200);
		l.Add(300);
		l.Add(400);
		itr = stk;
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}
		itr = q;
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}
		/*itr = l;
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}*/

		itr = l.GetIterator();
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}

		itr = l.GetIterator();
		while(itr.HasNext())
		{
			System.Console.WriteLine(itr.Next());
		}

	}
}