using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Services.Abstractions;

namespace Modul2HW6.Services
{
    public class ElectricalAppliancesService
    {
        private readonly SortService _sortService;

        public ElectricalAppliancesService()
        {
            _sortService = new SortService();
        }

        public void SortSocket()
        {
            Array.Sort();
        }
    }
}
