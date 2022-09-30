using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.WaterCleaning.WashingMachine.Philips
{
    public class STR97020WashingMashine : PhilipsWashingMashine
    {
        public override string Name { get; set; } = "STR97020";
        public override int Volt { get; set; } = 220;
        public override int Power { get; set; } = 700;
        public override string Type { get; set; } = "WashingMachine";

    }
}
