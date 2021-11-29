using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Services;
using Modul2HW6.Services.Abstractions;

namespace Modul2HW6
{
    public class Starter
    {
        private readonly IUIService _iuIService;

        public Starter(IUIService uIService)
        {
            _iuIService = uIService;
        }

        public void Run()
        {
            _iuIService.Info();
            _iuIService.Sort();
            _iuIService.FindApp();
        }
    }
}
