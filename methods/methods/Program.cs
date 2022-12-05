using System;
 class Program
    {
    static float Fonksiyon(float x) { return 2 * x + 5; }
 static float TersFonksiyon(float x) { return (x - 5) / 2; }
 static void Main()
    {
        float x = 10;
 Console.WriteLine(Fonksiyon(x));
Console.WriteLine(TersFonksiyon(x));
 Console.WriteLine(Fonksiyon(TersFonksiyon(x)));
        Console.ReadLine();
    }
}
      
        
    

