class Collection
{
	private int []x;
	public int count{set;get;};
	public Collection()
	{
		x = new int[10];
	}
	public Collection(int size)
	{
		x = new int[size];
	}
	public void Add(int val)
	{
		x[count++] = val;
	}
	public int this[int index]
	{	
		get{
			return x[index];
		}
	}
}
class List
{
	private Collection c;
	public List()
	{
		c = new Collection();
	}
	public List(int size)
	{
		c = new Collection(size);
	}
	public Collection Iteams{
		get{
		return c;
		}
	}
}













