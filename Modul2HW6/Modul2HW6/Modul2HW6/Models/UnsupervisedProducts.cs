﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models
{
    public abstract class UnsupervisedProducts : ElectricalAppliances
    {
        public virtual bool HighProtectionAgainstElectricShock { get; set; }
    }
}
