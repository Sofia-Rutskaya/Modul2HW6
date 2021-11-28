using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models.Abstracts;

namespace Modul2HW6.Models
{
    public class ElectricWaffleMaker : HeatingElectricalAppliances
    {
        public override string Name { get; set; } = "Electric waffle maker";
        public override double Weight { get; set; }
        public override double Сapacity { get; set; }
        public override bool NonStickCoating { get; set; } = true;
        public override bool PotentiallyDangerous { get; set; } = true;
        public override TypeAppliances Appliances { get; set; } = TypeAppliances.ElectricWaffleMaker;
    }
}
