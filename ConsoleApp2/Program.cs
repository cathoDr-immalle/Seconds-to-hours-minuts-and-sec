using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            tijdBereken(2549);
            tijdBereken(3600);
            tijdBereken(5489);
            tijdBereken(131614154);

            Console.Read();
        }

        static void tijdBereken(int TotaalAantalSeconde)
        {
            int Uren = TotaalAantalSeconde / 3600;
            int Minuten =(TotaalAantalSeconde - (Uren*3600)) / 60;
            int seconden;

            if (Minuten == 0)
            {
                seconden = 0;
            }else
            {
                seconden =(TotaalAantalSeconde - (Uren * 3600) - (Minuten * 60));
            } 
            
            Console.WriteLine("{0} seconden = {1} uren, {2} minuten en {3} seconden.", TotaalAantalSeconde, Uren, Minuten, seconden);
        }

    }
}
