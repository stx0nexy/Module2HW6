using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.NotWaterCleaning.VacuumСleaner.Samsung
{
    public class SC4520VacuumCleaner : SamsungVacuumCleaner
    {
        public override string Name { get; set; } = "SC4520";
        public override int Volt { get; set; } = 220;
        public override int Power { get; set; } = 900;
        public override string Type { get; set; } = "VacuumСleaner";

    }
}
