﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprava.Entiteti
{
    public class SkolskiPolicajac:Policajac
    {
		public virtual string SrednjaIliOsnovna { get; set; }
        public virtual string NazivSkole { get; set; }
       // public virtual string AdresaSkole { get; set; }
        public virtual string OsobaZaKontakt { get; set; }
        public virtual string BrojTelefonaSkole { get;  set; }

        #region ToStringFunc
        public override string ToString()
        {
	        StringBuilder displayStringBuilder = new StringBuilder();
	        displayStringBuilder.AppendLine();
	        displayStringBuilder.AppendFormat(
		        "Srednja ili osnovna:{0},Naziv skole{1},Osoba za kontakt{2},Broj telefona skole:{3}", SrednjaIliOsnovna,
		        NazivSkole, OsobaZaKontakt, BrojTelefonaSkole);
	        return base.ToString() + displayStringBuilder.ToString();
        }
        #endregion

    }
}
