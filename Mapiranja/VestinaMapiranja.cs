﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Uprava.Entiteti;

namespace Uprava.Mapiranja
{
    public class VestinaMapiranja : ClassMap<Vestina>
    {

        public VestinaMapiranja()
        {
            Table("VESTINA");

            Id(x => x.VestinaId, "VESTINAID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");

            References(x => x.PripadaPolicajcu).Column("POLICAJACID").LazyLoad();
        }
    }
}
