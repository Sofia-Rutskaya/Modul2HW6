using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;

namespace Modul2HW6.Services
{
    public class SortService : IComparer<>
    {
        private readonly ElectricalAppliances[] _animals;
        private readonly ISafariParkSectionService _safariParkSectionService;

        public SortService(ISafariParkSectionService safariParkSectionService)
        {
            _safariParkSectionService = safariParkSectionService;
            _animals = _safariParkSectionService.GetAnimal();
        }

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
