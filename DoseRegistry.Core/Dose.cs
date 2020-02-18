using System;
using System.Collections.Generic;
using System.Text;

namespace DoseRegistry.Core
{
    public class Dose
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DoseType Type { get; set; }
        public string Unit { get; set; }
    }
}
