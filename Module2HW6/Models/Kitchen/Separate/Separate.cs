using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.Separate
{
    public abstract class Separate : Kitchen
    {
        public override bool IsSeparate { get; set; } = true;
    }
}
