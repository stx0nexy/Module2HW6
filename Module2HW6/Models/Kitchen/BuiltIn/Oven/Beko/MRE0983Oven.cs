using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.BuiltIn.Oven.Beko
{
    public class MRE0983Oven : BekoOven
    {
        public override string Name { get; set; } = "MRE0983";
        public override int Volt { get; set; } = 220;
        public override int Power { get; set; } = 1100;
        public override string Type { get; set; } = "Oven";

    }
}
