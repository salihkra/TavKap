using System;
using System.Collections.Generic;
using System.Text;

namespace TavKap
{
    public class KapModel : HayvanModel
    {
        public void kos(int zar)
        {
            this.isim = "Kap";
            if (zar >= 1 && zar <= 3)
            {
                this.pistKonum += 2;
              Console.WriteLine(isim + " koştu!");
            }
            else if (zar == 4 || zar == 5)
            {
                this.pistKonum -= 1;
                Console.WriteLine(isim + " uyuyakaldı!");
            }
            else
            {
                Console.WriteLine(isim + " yemek yiyiyor!");
            }
            Console.WriteLine(isim + " : " + getPistKonum());
        }
    }
}
