using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_left_for_christmas
{
    class days_left_christmas
    {
        static void Main(string[] args)
        {
            bool risp = true;
            Console.Write("Vuoi sapere tra quanto è Natale? [s/n]");
            char risposta = Convert.ToChar(Console.ReadLine());
            giorni(risposta == 's' ? risp == true : risp == false);
            Console.ReadKey();
        }
        static void giorni(bool cond)
        {
            if (cond)
            {
                DateTime oggi = DateTime.Today;
                DateTime Natale = new DateTime(oggi.Year, 12, 25);
                int giorni_rimanenti = Convert.ToInt32(Natale.DayOfYear) - Convert.ToInt32(oggi.DayOfYear);
                if (giorni_rimanenti < 0)
                {
                    DateTime ultimo = new DateTime(oggi.Year, 12, 31);
                    int tmp = Convert.ToInt32(ultimo.DayOfYear) - Convert.ToInt32(oggi.DayOfYear);
                    giorni_rimanenti = tmp + Convert.ToInt32(Natale.DayOfYear);
                    Console.WriteLine($"Mancano {giorni_rimanenti} giorni a Natale!");
                    return;
                }
                Console.WriteLine($"Mancano {giorni_rimanenti} giorni a Natale!");
                Console.Write("Non sei contento?");
            }
            else
            {
                Console.WriteLine("Come vuoi,rimani col dubbio...");
            }
        }
    }
}
