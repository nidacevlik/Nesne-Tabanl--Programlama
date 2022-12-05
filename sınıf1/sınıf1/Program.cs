using System;
class Ogrenci
{
    public ulong OgrenciNo;
    public string Ad;
    public string Soyad;
    public string Bolum;
    public byte Sinif;
}
class Program
{
static void Main(string[] args)
        {
        Ogrenci ogr = new Ogrenci();
        Console.WriteLine(ogr.OgrenciNo);
        Console.WriteLine(ogr.Ad);
        Console.WriteLine(ogr.Soyad);
        Console.WriteLine(ogr.Bolum);
        Console.WriteLine(ogr.Sinif);
        Console.ReadLine();
        }
    
}

        

