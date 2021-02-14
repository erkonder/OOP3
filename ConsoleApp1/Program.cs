using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool tekrarSor = true;

            while (tekrarSor == true)
            {
                Console.WriteLine("Kelime Gir : ");
                string ilkKelime = Console.ReadLine();
                string kontrolKelime = "";

                for (int i = ilkKelime.Length - 1; i >= 0; i--)
                {
                    kontrolKelime += ilkKelime[i];
                }

                if (ilkKelime.Equals(kontrolKelime))
                {
                    Console.WriteLine("palindrom");
                    
                }
                
                else
                    Console.WriteLine("Değil");
                
            }




        }
    }

}
