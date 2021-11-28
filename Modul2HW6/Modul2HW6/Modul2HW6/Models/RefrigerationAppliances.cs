using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models
{
    public abstract class RefrigerationAppliances : UnsupervisedProducts
    {
        public virtual int TemperatureInside { get; set; }
        public virtual TypeOfRefrigerationAppliances Appliance { get; set; }
        public virtual double Volume { get; set; }
    }
}
