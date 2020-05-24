using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprava.Entiteti
{
    public class SkolskiPolicajac
    {
        public virtual int PolicajacId { get; protected set; }
        public virtual string SrednjaIliOsnovna { get; set; }
        public virtual string NazivSkole { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string OsobaZaKontakt { get; set; }
        public virtual string BrTelefonaSkole { get; set; }

        public virtual Policajac PripadaPolicajcu { get; set; }

        public virtual IList<Patrola> Patrole { get; set; }

        public SkolskiPolicajac()
        {
            Patrole = new List<Patrola>();
        }
    }
}
