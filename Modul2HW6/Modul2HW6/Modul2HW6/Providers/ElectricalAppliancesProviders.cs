using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;
using Modul2HW6.Models.Abstracts;
using Modul2HW6.Providers.Abstractions;

namespace Modul2HW6.Providers
{
    public class ElectricalAppliancesProviders : IElectricalAppliancesProviders
    {
        private readonly ElectricalAppliances[] _electricalAppliances;

        public ElectricalAppliancesProviders()
        {
            _electricalAppliances = new ElectricalAppliances[]
            {
                new Fridge
                {
                    Weight = 67.6,
                    Сapacity = 250,
                    Appliances = TypeAppliances.Fridge
                },
                new Hairdryer
                {
                    Weight = 1.5,
                    Сapacity = 1200,
                    Appliances = TypeAppliances.Hairdryer
                },
                new WashingMashines
                {
                    Weight = 65,
                    Appliances = TypeAppliances.WashingMashines,
                    Сapacity = 500,
                    NumberOfModes = 5
                },
                new ElectricWaffleMaker
                {
                    Weight = 0.9,
                    Appliances = TypeAppliances.ElectricWaffleMaker,
                    Сapacity = 780
                }
            };
        }

        ElectricalAppliances[] IElectricalAppliancesProviders.GetApps()
        {
            return _electricalAppliances;
        }
    }
}
