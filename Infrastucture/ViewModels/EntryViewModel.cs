﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.ViewModels
{
    public class EntryViewModel
    {
        public string Datereceipt { get; set; }
        public long Statusreceipt { get; set; }
        public virtual ProcedureEntity Procedure { get; set; }
        public virtual PatientEntity Patient { get; set; }
    }
}
