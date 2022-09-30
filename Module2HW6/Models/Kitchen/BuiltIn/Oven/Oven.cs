using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.BuiltIn.Oven
{
    public abstract class Oven : BuiltIn
    {
        public abstract BrandType Brand { get; set; }
    }
}
