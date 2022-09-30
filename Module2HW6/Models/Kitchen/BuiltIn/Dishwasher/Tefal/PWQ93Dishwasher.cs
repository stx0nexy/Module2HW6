using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.BuiltIn.Dishwasher.Tefal
{
    public class PWQ93Dishwasher : TefalDishwasher
    {
        public override string Name { get; set; } = "PWQ93";
        public override int Volt { get; set; } = 240;
        public override int Power { get; set; } = 700;
        public override string Type { get; set; } = "Dishwasher";

    }
}
