using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models.Kitchen.BuiltIn
{
    public abstract class BuiltIn : Kitchen
    {
        public override bool IsSeparate { get; set; } = false;
    }
}
