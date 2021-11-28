using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models.Abstracts;

namespace Modul2HW6.Models
{
    public abstract class ElectricalAppliances
    {
        public abstract string Name { get; set; }
        public abstract double Weight { get; set; }
        public abstract double Сapacity { get; set; }
        public abstract TypeAppliances Appliances { get; set; }
    }
}
