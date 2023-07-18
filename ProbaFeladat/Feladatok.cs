using System;
using System.Collections.Generic;
using System.Globalization;
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

        public void NyolcadikFeladat(List<Kutya> kutyak, List<KutyaFajta> kutyaFajtak, string keresettDatum)
        {
            Dictionary<String, int> kezeltKutyak = new Dictionary<String, int>();

            string format = "yyyy.MM.dd";
            DateOnly nap = DateOnly.ParseExact(keresettDatum, format, CultureInfo.InvariantCulture);

            foreach (Kutya item in kutyak)
            {
                foreach (KutyaFajta item2 in kutyaFajtak)
                {
                    if (item.EllenorzesDatuma.Equals(nap) && item.FajtaId == item2.FajtaId)
                    {
                        kezeltKutyak.Add(item2.FajtaNev, 0);
                    }
                }
                
            }

            foreach(Kutya item in kutyak)
            {
                foreach (var item1 in kezeltKutyak)
                {
                    foreach (KutyaFajta item2 in kutyaFajtak)
                    {
                        if(item.EllenorzesDatuma.Equals(nap) && item.FajtaId == item2.FajtaId)
                        {
                            if(item2.FajtaNev == item1.Key)
                            {
                                kezeltKutyak[item2.FajtaNev] = (item1.Value + 1);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("8. feladat: Január 10-én viszgált kutyafajták:\n");
            foreach (var item in kezeltKutyak)
            {
                Console.WriteLine(item.Key+", "+item.Value+" kutya\n");
            }

        }

        public void KilencedikFeladat(List<Kutya> kutyak)
        {
            Dictionary<DateOnly, int> datumok = new Dictionary<DateOnly, int>();

            foreach (Kutya kutya in kutyak)
            {
                if (!datumok.ContainsKey(kutya.EllenorzesDatuma))
                {
                    datumok.Add(kutya.EllenorzesDatuma, 0);
                }

               
            }

            foreach (Kutya kutya in kutyak)
            {
                foreach (var item in datumok)
                {
                    if(kutya.EllenorzesDatuma.Equals(item.Key))
                    {
                        datumok[item.Key] = (item.Value + 1);
                    }
                }
            }

           var kutyakSzama = datumok.Max(x => x.Value);
           var keresettDatum = datumok.MaxBy(y=> y.Value).Key;

           Console.WriteLine("9. feladat: A legjobban leterhelt nap: "+keresettDatum+": "+kutyakSzama+" kutya");


        }


    }
}
