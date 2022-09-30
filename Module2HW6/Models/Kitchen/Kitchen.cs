using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen
{
    public abstract class Kitchen : ElectricalAppliances
    {
        public AreaType AreaType { get; set; } = AreaType.Kitchen;
        public abstract bool IsSeparate { get; set; }
    }
}
