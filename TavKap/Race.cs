using System;
using System.Collections.Generic;
using System.Text;

namespace TavKap
{
    public class Race
    {
        Random rd = new Random();
        TavModel tm = new TavModel();
        KapModel km = new KapModel();

        public void yarisaBasla()
        {
          
            while ((tm.getPistKonum() < 100) && (km.getPistKonum() < 100))
            {
                tm.kos(rd.Next(6) + 1);
                km.kos(rd.Next(6) + 1);
            }
            if (tm.getPistKonum() == 100 && km.getPistKonum() == 100)
            {
                Console.WriteLine("Berabere !!! ");
            }
            else if (tm.getPistKonum() >= 100)
            {
                Console.WriteLine("Tavşan Kazandı");
            }
            else if (km.getPistKonum() >= 100)
            {
                Console.WriteLine("Kaplumbağa Kazandı");
            }
        }
    }
}
