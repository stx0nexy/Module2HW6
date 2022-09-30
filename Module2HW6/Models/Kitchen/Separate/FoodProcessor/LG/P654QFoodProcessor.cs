using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.Separate.FoodProcessor.LG
{
    public class P654QFoodProcessor : LGFoodProcessor
    {
        public override string Name { get; set; } = "P654Q";
        public override int Volt { get; set; } = 110;
        public override int Power { get; set; } = 400;
        public override string Type { get; set; } = "FoodProcessor";
    }
}
