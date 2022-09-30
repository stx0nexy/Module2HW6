using Module2HW6.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.Separate.FoodProcessor.LG
{
    public abstract class LGFoodProcessor : FoodProcessor
    {
        public override BrandType Brand { get; set; } = BrandType.LG;
    }
}
