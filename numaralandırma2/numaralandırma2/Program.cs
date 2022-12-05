using System;
enum GUNLER : byte
{
    PAZARTESI,
    SALI,
    CARSAMBA,
    PERSEMBE,
    CUMA,
    CUMARTESI,
    PAZAR
}
class Numaralandirma
{
    public static void Main()
    {
        Console.WriteLine((int)GUNLER.PAZARTESI);
        Console.WriteLine((int)GUNLER.PAZAR);
        Console.ReadLine();
    }
}