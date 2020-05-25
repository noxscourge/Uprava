﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprava.Entiteti
{
    public class Vestina
    {
        public virtual int VestinaId { get; protected set; }
        public virtual VanredniPolicajac PripadaPolicajcu { get; set; } //vanredni

        public virtual string Naziv { get; set; }
    }
}
