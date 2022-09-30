using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.Separate.Microwave.Bosch
{
    public abstract class BoschMicrowave : Microwave
    {
        public override BrandType Brand { get; set; } = BrandType.Bosch;
    }
}
