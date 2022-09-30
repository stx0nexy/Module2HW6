using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.Separate.Microwave.Bosch
{
    public class MB10Microwave : BoschMicrowave
    {
        public override string Name { get; set; } = "MB10";
        public override int Volt { get; set; } = 220;
        public override int Power { get; set; } = 1200;
        public override string Type { get; set; } = "Microwave";
    }
}
