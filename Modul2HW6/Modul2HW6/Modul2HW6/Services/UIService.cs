using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Services.Abstractions;
using Modul2HW6.Providers;
using Modul2HW6.Providers.Abstractions;
using Modul2HW6.Extensions;

namespace Modul2HW6.Services
{
    public class UIService : IUIService
    {
        private readonly ICountCapacity _countCapacity;
        private readonly IElectricalAppliancesService _appliancesService;
        private StringBuilder _message;

        public UIService(ICountCapacity countCapacity, IElectricalAppliancesService appliancesService)
        {
            _appliancesService = appliancesService;
            _countCapacity = countCapacity;
            _message = new StringBuilder();
        }

        void IUIService.Info()
        {
            _message.Clear();
            _message.Append($"Power consumption - ");
            _message.Append($" {_countCapacity.GetCapacity()}");
            Console.WriteLine(_message);
        }

        void IUIService.Sort()
        {
            _message.Clear();
            _appliancesService.SortSocket();
            _message.Append('-', 10);
            _message.Append("Array sorted");
            _message.Append('-', 10);
            Console.WriteLine(_message);
        }

        void IUIService.FindApp()
        {
            if (_appliancesService.GetApps().FindAppliance("Hairdryer", Models.Abstracts.TypeAppliances.Hairdryer) == null)
            {
                Console.WriteLine("Doesn't exist");
            }
            else
            {
                Console.WriteLine("Exist");
            }
        }
    }
}
