using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprava.Entiteti
{
	public class Patrola
	{
		public virtual int PatrolaId { get; set; }
		public virtual PozornikPolicajac Vodja { get; set; }
		public virtual PozornikPolicajac Partner { get; set; }
		public virtual SluzbenoVozilo Vozilo { get; set; }
		public virtual IList<Intervencija> imalaIntervencije { get; set; }
	
	  public Patrola()
		{
			imalaIntervencije = new List<Intervencija>();
		}
	}
}
