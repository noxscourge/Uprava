using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Uprava.Entiteti;

namespace Uprava.Mapiranja
{
    public class SkolskiPolicajacMapiranja : SubclassMap<SkolskiPolicajac>
    {
        public SkolskiPolicajacMapiranja()
        {
            Table("SKOLSKI_POLICAJAC");

            KeyColumn("POLICAJACID");
            //DiscriminatorValue("SKOLSKI");


            Map(x => x.NazivSkole, "NAZIV_SKOLE");
            //Map(x => x.AdresaSkole, "ADRESA");
            Map(x => x.BrojTelefonaSkole, "BR_TELEFONA_SKOLE");
            Map(x => x.OsobaZaKontakt, "OSOBA_ZA_KONTAKT");
            Map(x => x.SrednjaIliOsnovna, "SREDNJA_ILI_OSNOVNA");

           
        }
    }
}
