using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models
{
    public abstract class SupervisedProducts : ElectricalAppliances
    {
        public virtual int AmountOfTimeOfUse { get; set; }
        public virtual bool PotentiallyDangerous { get; set; }
    }
}
