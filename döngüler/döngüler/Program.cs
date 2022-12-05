using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine("i=" + i);
            i++;
        }
        //do-while
        int i1 = 0; //döngü kontrol değişkeni
        do
        {
            Console.WriteLine("i1 = " + i1);
            i1++;
        } while (i1 < 0);
        //do-while ve switch
        int secim;
        do
        {
            Console.WriteLine("işlemler\n========");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.WriteLine("0- Çıkış\n");
            Console.Write("İşleminizi seçin:");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1: Console.WriteLine("Toplama işlemi seçildi."); break;
                case 2: Console.WriteLine("Çıkarma işlemi seçildi."); break;
                case 3: Console.WriteLine("Çarpma işlemi seçildi."); break;
                case 4:
                    Console.WriteLine("Bölme işlemi seçildi."); break;
                case0: Console.WriteLine("Çıkış seçildi"); break;
                default: Console.WriteLine("Yanlış seçim."); break;


            }

        }
        while (secim != 0);
        //for döngüsü
        for (int i2 = 0, j = 0; i2 < 20; i2++, j++)
        {
            i2 *= j;
            Console.WriteLine("i = " + i2 + " j = " + j);

        }
        //for2
        string s;
        for (s = Console.ReadLine(); s != "Çıkış"; s = Console.ReadLine())
            Console.WriteLine(s);
        //for
        int sayi;
        Console.Write("Bir tamsayı giriniz:");
        sayi= Convert.ToInt32(Console.ReadLine());

        for(int bit = 32; bit >= 1; bit--)
        {
            Console.Write("{0}",(sayi>>bit-1)&1);
        }
        Console.WriteLine();


    }
}

