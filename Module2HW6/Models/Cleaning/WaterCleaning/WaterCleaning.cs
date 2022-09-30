using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.WaterCleaning
{
    public abstract class WaterCleaning : Cleaning
    {
        public override bool IsConectWithWater { get; set; } = true;
    }
}
