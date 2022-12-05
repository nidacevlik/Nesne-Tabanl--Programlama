using System;
class Zaman
{
 public int Saat; public int Dakika; public int Saniye;
 public Zaman(int saat, int dakika, int saniye)
 {       Dakika=dakika+saniye/60;
         Saniye=saniye%60;
         Saat=saat+Dakika/60;
         Dakika=Dakika%60;
 }
 public static Zaman operator+(Zaman a, Zaman b)
 {
            int ToplamSaniye = a.Saniye + b.Saniye;
            int ToplamDakika = a.Dakika + b.Dakika;
            int ToplamSaat = a.Saat + b.Saat;
            return new Zaman(ToplamSaat, ToplamDakika, ToplamSaniye);
        
    }
 }

