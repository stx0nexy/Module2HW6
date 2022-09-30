using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.NotWaterCleaning.ClothesDryer.Beko
{
    public class DC7130ClothesDryer : BekoClothesDryer
    {
        public override string Name { get; set; } = "DC7130";
        public override int Volt { get; set; } = 210;
        public override int Power { get; set; } = 1200;
        public override string Type { get; set; } = "ClothesDryer";

    }
}
