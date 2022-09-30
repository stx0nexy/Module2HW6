using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.NotWaterCleaning
{
    public abstract class NotWaterCleaning : Cleaning
    {
        public override bool IsConectWithWater { get; set; } = false;
    }
}
