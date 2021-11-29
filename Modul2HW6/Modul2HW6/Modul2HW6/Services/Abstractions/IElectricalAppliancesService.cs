﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;

namespace Modul2HW6.Services.Abstractions
{
    public interface IElectricalAppliancesService
    {
        public void SortSocket();
        public ElectricalAppliances[] GetApps();
    }
}
