using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaFeladat
{
    public class Kutya
    {
        private int kutyaId;
        private int fajtaId;
        private int nevId;
        private int eletKor;
        private DateOnly ellenorzesDatuma;

        public Kutya(int kutyaId, int fajtaId, int nevId, int eletKor, DateOnly ellenorzesDatuma)
        {
            this.kutyaId = kutyaId;
            this.fajtaId = fajtaId;
            this.nevId = nevId;
            this.eletKor = eletKor;
            this.ellenorzesDatuma = ellenorzesDatuma;
        }

        public int KutyaID
        {
            get => kutyaId;

        }

        public int FajtaId
        {
            get => fajtaId;
        }

        public int NevId
        {
            get => nevId;
        }

        public int Eletkor
        {
            get => eletKor;
        }

        public DateOnly EllenorzesDatuma
        {
            get => ellenorzesDatuma;
        }

        public override string? ToString()
        {
            return "Kutya azonosító: "+kutyaId+", fajta azonosító: "+fajtaId+", név azonosító: "+nevId+", életkor: "+eletKor+", utolsó orvosi ellenőrzés datuma: "+ellenorzesDatuma;
        }
    }
}
