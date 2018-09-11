using System;
using System.Collections.Generic;
using System.Text;

namespace Boerman.OpenAip
{
    public class Radio
    {
        public decimal Frequency { get; set; }

        public RadioType Type { get; set; }

        public string TypeSpecification { get; set; }

        public string Description { get; set; }

        public RadioCategory Category { get; set; }
    }
}
