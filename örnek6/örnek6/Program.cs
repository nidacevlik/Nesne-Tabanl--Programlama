using System;
class
A
{
    public void Metot1()
    { Metot2(); }
    virtual public void Metot2()
    { Console.WriteLine("A sınıfı"); }
}
class B : A
{
    override public void Metot2()
    { Console.WriteLine("B sınıfı"); }
}
class Ana
{
    static void Main()
    {
        B b = new B();
        b.Metot1();
        Console.ReadLine();
    }
}