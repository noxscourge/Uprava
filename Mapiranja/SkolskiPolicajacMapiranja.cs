using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Uprava.Entiteti;

namespace Uprava.Mapiranja
{
    public class SkolskiPolicajacMapiranja : ClassMap<SkolskiPolicajac>
    {
        public SkolskiPolicajacMapiranja()
        {
            Table("SKOLSKI_POLICAJAC");
                Id(x => x.PolicajacId, "POLICAJACID").GeneratedBy.TriggerIdentity();
            Map(x => x.NazivSkole, "NAZIV_SKOLE");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrTelefonaSkole, "BR_TELEFONA_SKOLE");
            Map(x => x.OsobaZaKontakt, "OSOBA_ZA_KONTAKT");
            Map(x => x.SrednjaIliOsnovna, "SREDNJA_ILI_OSNOVNA");

           
        }
    }
}
