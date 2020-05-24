using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate.Utils;
using Uprava.Entiteti;

namespace Uprava.Mapiranja
{
	public class PolicajacMapiranja : ClassMap<Policajac>
	{
		public PolicajacMapiranja()
		{
			Table("POLICAJAC");

			Id(x => x.PolicajacId, "POLICAJACID").GeneratedBy.TriggerIdentity();

			Map(x => x.Ime, "IME");
			Map(x => x.ImeRoditelja, "IME_RODITELJA");
			Map(x => x.Prezime, "PREZIME");
			Map(x => x.Pol, "POL");
			Map(x => x.Jmbg, "JMBG");
			Map(x => x.Adresa, "ADRESA");
			Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
			Map(x => x.DatumSticanjaDiplome, "DATUM_STICANJA_DIPLOME");
			Map(x => x.Kurs, "KURS");
			Map(x => x.Skola, "SKOLA");
			Map(x => x.NazivObrazovanja, "NAZIV_OBRAZOVANJA");
			Map(x => x.DatumPrijema, "DATUM_PRIJEMA");
			//Map(x => x.Pozicija, "");
			//Map(x => x.TipPosla, "");
			References(x => x.PripadaPolicijskaStanica).Column("STANICAID").LazyLoad();
			//HasOne(x => x.VodjaPatrole).ForeignKey("VODJAID").LazyLoad();
			//HasOne(x => x.PartnerUPatroli).ForeignKey("PARNERID").LazyLoad();
			//HasMany(x => x.Cinovi).KeyColumn("POLICAJACID").LazyLoad().Cascade.All().Inverse();
		}
	}
}
