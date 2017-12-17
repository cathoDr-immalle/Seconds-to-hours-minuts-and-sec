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

            Console.WriteLine(" ");

            tijdInSeconde(0, 42, 29);
            tijdInSeconde(12, 24, 53);
            tijdInSeconde(24, 0, 0);
            tijdInSeconde(36, 36, 36);

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

        static void tijdInSeconde(int uur, int min, int sec)
        {
            int TotaalSeconde = (uur * 3600) + (min * 60) + sec;
            Console.WriteLine("{0} uur, {1} minuten en {2} seconden = {3} seconden in totaal.", uur, min, sec, TotaalSeconde);
        }

    }
}
