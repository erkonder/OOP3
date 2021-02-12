using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);


            int[] sayilar1 = { 10, 20, 30 };
            int[] sayilar2 = { 123, 456, 789 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1;

            //Console.WriteLine(sayilar1[0]);

        }
    }
}
