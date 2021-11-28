using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models
{
    public abstract class PersonalHygieneDevices : SupervisedProducts
    {
        public virtual bool WiredAppliances { get; set; }
        public virtual int NumberOfNozzles { get; set; }
    }
}
