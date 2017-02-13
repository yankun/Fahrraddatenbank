using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
	public class CrankAxle : BaseModel, IManufactureRelatedItem
	{
        private string usedAt;

		public double Width { get; set; }
		public double ThreadDiameter { get; set; }
		public int ThreadPitch { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public virtual Manufacturer Manufacturer { get; set; }

        [Display(Name = nameof(ManufacturerId), ResourceType = typeof(Resources.PropertyNames))]
        public Guid ManufacturerId { get; set; }

        public string UsedAt
        {
            get
            {
                return usedAt;
            }
            set
            {
                int? validFrom, validTo;

                TimeEstimateParser.ParseTimeEstimate(value, out validFrom, out validTo);

                UsedAtValidFrom = validFrom;
                UsedAtValidTo = validTo;
            }
        }

        public int? UsedAtValidFrom { get; private set; }
        public int? UsedAtValidTo { get; private set; }
    }
}
