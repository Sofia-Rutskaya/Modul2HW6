using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Services.Abstractions;
using Modul2HW6.Providers;
using Modul2HW6.Providers.Abstractions;
using Modul2HW6.Models;

namespace Modul2HW6.Services
{
    public class ElectricalAppliancesService : IElectricalAppliancesService
    {
        private readonly IElectricalAppliancesProviders _appliancesProviders;

        public ElectricalAppliancesService(IElectricalAppliancesProviders appliancesProviders)
        {
            _appliancesProviders = appliancesProviders;
        }

        void IElectricalAppliancesService.SortSocket()
        {
            Array.Sort(_appliancesProviders.GetApps(), new SortService());
        }

        ElectricalAppliances[] IElectricalAppliancesService.GetApps()
        {
            return _appliancesProviders.GetApps();
        }
    }
}
