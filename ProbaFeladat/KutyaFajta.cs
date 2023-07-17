using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaFeladat
{
    public class KutyaFajta
    {
        private int fajtaId;
        private string fajtaNev;
        private string eredetiFajtaNev;

        public KutyaFajta(int fajtaId, string fajtaNev, string eredetiFajtaNev)
        {
            this.fajtaId = fajtaId;
            this.fajtaNev = fajtaNev;
            this.eredetiFajtaNev = eredetiFajtaNev;
        }

        public int FajtaId
        {
            get => fajtaId;
        }
        public string FajtaNev
        {
            get => fajtaNev;
        }

        public string EredetiFajtaNev
        {
            get => eredetiFajtaNev;
        }

        public override string? ToString()
        {
            return "Fajta azonosító: "+fajtaId+", fajta elnevezése: "+fajtaNev+", erdetedi fajtaelnevezés: "+eredetiFajtaNev;
        }
    }
}
