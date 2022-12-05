using System;
   class Diziler
    {
        static void Main(string[] args)
        {
        Random r= new Random();
        int[]dizi=new int[20];
        char[] chr=new char[20];

        for(int i=0; i<20; i++)
        {
            dizi[i]=r.Next(1,51);
            chr[i] = (char)r.Next(20, 126);

        }
        for(int i=0; i<20; i++)
        {
            Console.Write("{0,2}.değer{1,2}->", i, dizi[i]);
            for(int j = 0; j < dizi[i]; j++)
                Console.Write(chr[i]);
            Console.WriteLine();
        }
        //düzensiz diziler
        int[][] arr = new int[3][];
        arr[0] = new int[] { 1, 2 };
        arr[1] = new int[] { 3, 4, 5, 6, 7 };
        arr[2] = new int[] { 8, 9, 0 };

        foreach (int[] boyut in arr)
        {
            foreach(int eleman in boyut)
            {
                Console.Write("{0,3}",eleman);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
