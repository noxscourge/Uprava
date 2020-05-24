using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprava.Entiteti
{
	public abstract class AlarmniSistem
	{
        //serijskibr treba da bude int
		public virtual string SerijskiBr { get; set; }
		public virtual string Proizvodjac { get; set; }
		public virtual string Model { get; set; }
		public virtual string GodinaProizvodnje { get; set; }
		public virtual DateTime DatumInstalacije { get; set; }
		public virtual string Tip { get; set; }

		public virtual Objekat PripadaObjektu {get;set;} 
		public virtual DateTime DatumPoslednjegTesta { get; set; }
		public virtual DateTime DatumPoslednjegServisiranja { get; set; }
		public virtual string OtklonjenKvar { get; set; }
		public virtual IList<Zaduzen> Zaduzen { get; set; } //this

		public AlarmniSistem()
		{
			Zaduzen = new List<Zaduzen>();
		}
	}

	public class ToplotniAlarmniSistem:AlarmniSistem
	{
		public virtual string HorizontalnaRezolucija { get; set; }
		public virtual string VertikalnaRezolucija { get; set; }
	}

	public class UltrazvucniAlarmniSistem:AlarmniSistem
	{
		public virtual string Frekvencija { get; set; }

	}

	public class DetekcijaPokretaAlarmniSistem:AlarmniSistem
	{
		public virtual string Osetljivost { get; set; }

	}
}
