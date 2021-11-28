using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;
using Modul2HW6.Models.Abstracts;

namespace Modul2HW6.Extensions
{
    public static class SearchExtensions
    {
        public static ElectricalAppliances FindAppliance(this ElectricalAppliances[] appliances, string name, TypeAppliances type, double weight)
        {
            for (var i = 0; i < appliances.Length; i++)
            {
                if (appliances[i] == null)
                {
                    return null;
                }

                if (appliances[i].Name == name && appliances[i].Appliances == type && appliances[i].Weight == weight)
                {
                    return appliances[i];
                }
            }

            return null;
        }
    }
}
