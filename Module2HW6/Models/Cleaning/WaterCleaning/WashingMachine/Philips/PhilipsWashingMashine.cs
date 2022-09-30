using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.WaterCleaning.WashingMachine.Philips
{
    public abstract class PhilipsWashingMashine : WashingMachine
    {
        public override BrandType Brand { get; set; } = BrandType.Philips;
    }
}
