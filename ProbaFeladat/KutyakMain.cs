﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaFeladat
{
    
        class KutyakMain
        {
            static void Main(string[] args)
            {
                List<Kutya> kutyak = new List<Kutya>();

                List<KutyaFajta> kutyaFajtak = new List<KutyaFajta>();

                List<KutyaNev> kutyaNevek = new List<KutyaNev>();

                Fajlbeolvasas fajl = new Fajlbeolvasas();

                Feladatok feladatok = new Feladatok();

                kutyak = fajl.KutyaListaBeolvasas("B:\\Kurs\\Feladatok\\Kutyak\\Kutyak.csv",";");

                kutyaFajtak = fajl.FajtaListaBeolvasas("B:\\Kurs\\Feladatok\\Kutyak\\KutyaFajtak.csv", ";");

                kutyaNevek = fajl.NevListaBeolvasas("B:\\Kurs\\Feladatok\\Kutyak\\KutyaNevek.csv", ";");

                feladatok.HarmadikFeladat(kutyaNevek);
                Console.ReadLine();
                feladatok.HatodikFeladat(kutyak);
                Console.ReadLine();
                feladatok.HetedikFeladat(kutyak, kutyaFajtak, kutyaNevek);
                Console.ReadLine();

                
                

        }
        }
    }
