using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning.WaterCleaning.ElectricMop
{
    public abstract class ElectricMop : WaterCleaning
    {
        public abstract BrandType Brand { get; set; }
    }
}
