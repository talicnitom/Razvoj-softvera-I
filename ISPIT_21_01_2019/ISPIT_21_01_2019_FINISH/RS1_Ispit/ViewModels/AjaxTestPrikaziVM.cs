﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class AjaxTestPrikaziVM
    {
        public int MaturskiIspitStavkaId { get; set; }
        public string Ucenik { get; set; }
        public float ProsjekOcjena { get; set; }
        public string PristupioIspitu { get; set; }
        public string RezultatMaturskogIspita { get; set; }
    }
}
