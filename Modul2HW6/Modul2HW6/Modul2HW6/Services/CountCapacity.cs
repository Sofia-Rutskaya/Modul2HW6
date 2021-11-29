using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Services.Abstractions;
using Modul2HW6.Models;
using Modul2HW6.Providers;
using Modul2HW6.Providers.Abstractions;

namespace Modul2HW6.Services
{
    public class CountCapacity : ICountCapacity
    {
        private ElectricalAppliances[] _appliances;

        public CountCapacity(IElectricalAppliancesProviders appliancesProviders)
        {
            _appliances = appliancesProviders.GetApps();
        }

        double ICountCapacity.GetCapacity()
        {
            var capacity = 0.0;
            for (var i = 0; i < _appliances.Length; i++)
            {
                capacity += _appliances[i].Сapacity;
            }

            return capacity;
        }
    }
}
