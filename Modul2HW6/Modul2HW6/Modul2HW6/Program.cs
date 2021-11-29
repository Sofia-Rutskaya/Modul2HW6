using System;
using Microsoft.Extensions.DependencyInjection;
using Modul2HW6.Services;
using Modul2HW6.Services.Abstractions;
using Modul2HW6.Providers;
using Modul2HW6.Providers.Abstractions;
using Modul2HW6.Extensions;

namespace Modul2HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IElectricalAppliancesProviders, ElectricalAppliancesProviders>()
                .AddSingleton<IElectricalAppliancesService, ElectricalAppliancesService>()
                .AddSingleton<ICountCapacity, CountCapacity>()
                .AddSingleton<IUIService, UIService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
