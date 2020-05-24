﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprava.Entiteti
{
    public class Ulica
    {
        //metode
        public virtual int Ulicaid { get; protected set; }
        public virtual Policajac PripadaPolicajcu { get; set; }

        public virtual string Naziv { get; set; }
    }
}
