using System;
class X
{
    protected int a;
    public X(int a)
    {
        Console.WriteLine("X " + a);
        this.a = a;
    }
    public int A
    {
        get
        {
            Console.WriteLine("X Sınıfı=" + a);
            return a;
        }
    }
}
class Y : X
{
    protected int b;
    public Y(int a) : base(a)
    {
        Console.WriteLine("Y " + a);
        this.b = a;
    }
    new public int A
    {
        get
        {
            Console.WriteLine("Y sınıfı=" + b);
            return b;
            Console.ReadLine();

        }
    }
}
