using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.BuiltIn.Dishwasher.Tefal
{
    public abstract class TefalDishwasher : Dishwasher
    {
        public override BrandType Brand { get; set; } = BrandType.Tefal;
    }
}
