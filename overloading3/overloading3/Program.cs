using System;
class Sinif
 { public int Sayi;
     public Sinif(int sayi) { Sayi = sayi; }
 public static implicit operator int(Sinif a) { return a.Sayi; }
 }
 class AnaProgram
 {
    static void Main()
 {
        Sinif a = new Sinif(50);
 int b = a; Console.WriteLine(b);
        Console.ReadLine();
 }
 }


