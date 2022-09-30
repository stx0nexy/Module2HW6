using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.NotWaterCleaning.ClothesDryer.Philips
{
    public abstract class PhilipsClothesDryer : ClothesDryer
    {
        public override BrandType Brand { get; set; } = BrandType.Philips;
    }
}
