﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class OdrzanCasDetalj
    {
        public int Id { get; set; }

        [ForeignKey(nameof(OdjeljenjeStavkaId))]
        public OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public int OdjeljenjeStavkaId { get; set; }

        public bool Prisutan { get; set; }
        public bool? OpravdanoOdsutan { get; set; }

        [ForeignKey(nameof(OdrzanCasId))]
        public OdrzanCas OdrzanCas { get; set; }
        public int OdrzanCasId { get; set; }

        public string Napomena { get; set; }
    }
}
