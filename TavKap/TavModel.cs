using System;

namespace TavKap
{
    public class TavModel : HayvanModel { 
        public void kos(int zar)
        {
            this.isim = "Tav";

            if (zar >= 1 && zar <= 4) {
            this.pistKonum += 1;
            Console.WriteLine(isim + " yürüdü!");
        }
        else{
                Console.WriteLine(isim + " yemek yiyiyor!");
        }
            Console.WriteLine(isim + " : " + getPistKonum());
        }
    }
}
