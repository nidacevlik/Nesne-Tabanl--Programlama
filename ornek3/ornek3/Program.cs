using System;
class Program
 { 
 public int Zar()
 { Random rnd = new Random(); return rnd.Next(1, 7); }
 public static void metotlar(int a, int b, int c)
 { Console.WriteLine("a= " + a + " b= " + b + " c= " + c); }
 static void Main(string[] args)
 {
    Program a = new Program();
 metotlar(a.Zar(), a.Zar(), a.Zar());
        Console.ReadLine();
 }
 }
