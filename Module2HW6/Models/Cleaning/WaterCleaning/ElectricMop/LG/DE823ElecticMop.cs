using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.WaterCleaning.ElectricMop.LG
{
    public class DE823ElecticMop : LGElectricMop
    {
        public override string Name { get; set; } = "DE823";
        public override int Volt { get; set; } = 220;
        public override int Power { get; set; } = 1300;
        public override string Type { get; set; } = "ElectricMop";

    }
}
