using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models
{
    public abstract class LinenProcessingMachines : UnsupervisedProducts
    {
        // ironing machines. washing machines. Dryer
           public virtual int NumberOfModes { get; set; }
           public virtual int MaximumWeight { get; set; }
           public virtual int MaximumNumberOfRevolutions { get; set; }
    }
}
