using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Nostalji");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            selamla(sayi);

            Console.Read();
        }

        static void selamla(int tekrar)
        {
            tekrar--;
           Console.WriteLine(10-tekrar+"Günaydın sınıf");

            if(tekrar>0)
            {
                selamla(tekrar);
            }
        }
    }
}
