using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class Framenumber : BaseTimePeriodModel
    {
        public int Number { get; set; }

        public FrameNumberProof ProvenBy { get; set; }
    }
}
