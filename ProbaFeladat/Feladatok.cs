using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaFeladat
{
    public class Feladatok
    {
        public void HarmadikFeladat(List<KutyaNev> kutyaNevek)
        {
            Console.WriteLine("A kutyaneve száma: "+kutyaNevek.Count);
        }

        internal void HatodikFeladat(List<Kutya> kutyak)
        {
            int osszEletkor = 0;
            double atlag;

            foreach (Kutya kutya in kutyak)
            {
                osszEletkor += kutya.Eletkor;
            }
            atlag = Convert.ToDouble(osszEletkor) / Convert.ToDouble(kutyak.Count);

            Console.WriteLine(atlag.ToString("n2")+" év");
        }
    }
}
