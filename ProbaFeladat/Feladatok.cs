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
            Console.WriteLine("3. feladat: A kutyanevek száma: "+kutyaNevek.Count);
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

            Console.WriteLine("6. feladat: Kutyák átlagos életkora: "+atlag.ToString("n2")+" év");
        }

        public void HetedikFeladat(List<Kutya> kutyak, List<KutyaFajta> kutyaFajtak, List<KutyaNev> kutyaNevek)
        {
            Kutya kutya;
            String kutyaNeve = "";
            String kutyaFajtaja = "";

            int max = 0;

            for (int index = 0; index < kutyak.Count; index++)
            {
                if (kutyak[index].Eletkor > kutyak[max].Eletkor)
                {
                    max = index;
                }
            }

            kutya = kutyak[max];

            foreach (KutyaFajta fajtak in kutyaFajtak)
            {
                foreach (KutyaNev nevek in kutyaNevek)
                {
                    if(kutya.FajtaId == fajtak.FajtaId)
                    {
                        kutyaFajtaja = fajtak.FajtaNev;
                    }

                    if(kutya.KutyaID == nevek.KutyaId)
                    {
                        kutyaNeve = nevek.KutyaNeve;
                    }
                }
            }

            Console.WriteLine("7. feladat: Legidősebb kutya neve és fajtája: "+ kutyaNeve +", "+ kutyaFajtaja);
        }
    }
}
