using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.NotWaterCleaning.ClothesDryer.Philips
{
    public class GC9315ClothesDryer : PhilipsClothesDryer
    {
        public override string Name { get; set; } = "GC9315";
        public override int Volt { get; set; } = 220;
        public override int Power { get; set; } = 1800;
        public override string Type { get; set; } = "ClothesDryer";

    }
}
