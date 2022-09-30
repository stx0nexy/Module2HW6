using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Cleaning
{
    public abstract class Cleaning : ElectricalAppliances
    {
        public AreaType AreaType { get; set; } = AreaType.Cleaning;
        public abstract bool IsConectWithWater { get; set; }
    }
}
