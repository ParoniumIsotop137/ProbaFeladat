using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaFeladat
{
    internal class Fajlbeolvasas
    {

        public List<Kutya> KutyaListaBeolvasas(string fajlnev, string elvalaszto)
        {
            List<Kutya> kutyak = new List<Kutya>();

            StreamReader reader = new StreamReader(fajlnev);

            reader.ReadLine();

            try
            {
                while (!reader.EndOfStream)
                {

                    string[] sor = reader.ReadLine().Split(elvalaszto);

                    string format = "yyyy.MM.dd";
                    DateOnly date = DateOnly.ParseExact(sor[4], format, CultureInfo.InvariantCulture);

                    Kutya kutya = new Kutya(int.Parse(sor[0]), int.Parse(sor[1]), int.Parse(sor[2]), int.Parse(sor[3]), date);
                    kutyak.Add(kutya);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba a fájlok beolvasásakor!"+e.Message);
            }
            reader.Close();

            return kutyak;

        }

        public List<KutyaFajta> FajtaListaBeolvasas(string fajlnev, string elvalaszto)
        {
            List<KutyaFajta> fajtak = new List<KutyaFajta>();

            StreamReader reader = new StreamReader(fajlnev);

            reader.ReadLine();

            try
            {
                while (!reader.EndOfStream)
                {

                    string[] sor = reader.ReadLine().Split(elvalaszto);

                    KutyaFajta fajta = new KutyaFajta(int.Parse(sor[0]), sor[1], sor[2]);
                    fajtak.Add(fajta);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba a fájlok beolvasásakor!" + e.Message);
            }
            reader.Close();


            return fajtak;
        }

        internal List<KutyaNev> NevListaBeolvasas(string fajlnev, string elvalaszto)
        {
            List<KutyaNev> nevek = new List<KutyaNev>();

            StreamReader reader = new StreamReader(fajlnev);

            reader.ReadLine();

            try
            {
                while (!reader.EndOfStream)
                {

                    string[] sor = reader.ReadLine().Split(elvalaszto);

                    KutyaNev nev = new KutyaNev(int.Parse(sor[0]), sor[1]);
                    nevek.Add(nev);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba a fájlok beolvasásakor!" + e.Message);
            }
            reader.Close();

            return nevek;
        }

        public void NevListaFajlbaIrasa(Dictionary<string, int> nevek, string fajlnev)
        {

            var rendezve = nevek.OrderByDescending(x => x.Value).ToDictionary(x=> x.Key, x=> x.Value);

            StreamWriter writer = new StreamWriter(fajlnev, false);

            foreach (var item in rendezve)
            {
                String text = item.Key + ";" + item.Value;
                writer.WriteLine(text);
            }
            writer.Close();
            Console.WriteLine("10. feladat: nevstatisztika.txt");


        }
    }
}
