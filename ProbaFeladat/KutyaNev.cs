using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaFeladat
{
    public class KutyaNev
    {

        private int kutyaId;
        private string kutyaNeve;

        public KutyaNev(int kutyaId, string kutyaNeve)
        {
            this.kutyaId = kutyaId;
            this.kutyaNeve = kutyaNeve;
        }

        public int KutyaId
        {
            get => kutyaId;
        }

        public string KutyaNeve
        {
            get => kutyaNeve;
        }

        public override string ToString()
        {
            return "Kutya azonosító: "+kutyaId+", kutya neve: "+kutyaNeve;
        }
    }
}
