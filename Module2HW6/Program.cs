using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Services;
using Module2HW6.Services.Abstract;
using System;

namespace Module2HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceCollection()
                .AddTransient<IElectricalService, ElectricalService>()
                .AddTransient<IListElectrical, ListElectrical>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var starter = service.GetService<Starter>();
            starter.Run();
        }
    }
}
