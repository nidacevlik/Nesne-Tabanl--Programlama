using System;
interface Arayuz
{
    int Metot1();
    void Metot2();

    int Sayi
    {
        get;
        set;
    }
    int this[int indeks]
    {
        get;
    }
}
class Program
{
    static void Main()
    {
        Sinif s = new Sinif();
        Console.ReadLine();

    }
}
class Sinif : Arayuz
{
    private int sayi;
    public int Metot1()
    {
        return 0;
    }
    public void Metot2()
    {

    }
    public int Sayi
    {
        get { return sayi; }
        set { sayi = value; }
    }
    public int this[int indeks]
    {
        get { return indeks; }
        set { }
       
    }
    

}