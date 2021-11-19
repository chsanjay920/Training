struct Student{
    public int sno;
    public string sname;
    public double fee;
};

class structer
{
    static Student read(Student s)
    {
        s.sno = int.Parse(System.Console.ReadLine());
        s.sname = System.Console.ReadLine();
        s.fee =double.Parse(System.Console.ReadLine());
        return s;
    }
    static void print(Student s){
        System.Console.WriteLine("{0} {1} {2}",s.sno,s.sname,s.fee);
    }
    public static void Main()
    {
        Student s;
        s = new Student();
        s=read(s);
        print(s);
    }       
}