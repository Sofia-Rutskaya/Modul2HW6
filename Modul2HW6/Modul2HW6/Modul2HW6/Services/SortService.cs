using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;
using Modul2HW6.Services.Abstractions;

namespace Modul2HW6.Services
{
    public class SortService : IComparer<ElectricalAppliances>
    {
        public int Compare(ElectricalAppliances x, ElectricalAppliances y)
        {
            if (y == null || x == null)
            {
                return 0;
            }

            if (x.Weight < y.Weight)
            {
                var a = x;
                x = y;
                y = a;

                return 1;
            }
            else if (x.Weight > y.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
