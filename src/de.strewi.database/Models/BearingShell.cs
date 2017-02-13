using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
	public class BearingShell : BaseModel, IManufactureRelatedItem
	{
        private string usedAt;

		public string Image { get; set; }
		public double Depth { get; set; }
		public double OuterDiamteter { get; set; }
		public double InnerDiameter { get; set; }
		public double CrankHoleDiameter { get; set; }
		public Side Side { get; set; }
		public BearingShellPosition Position { get; set; }
		public bool IsThreaded { get; set; }
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
                usedAt = value;
            }
        }

        public int? UsedAtValidFrom { get; private set; }
        public int? UsedAtValidTo { get; private set; }

        [ForeignKey(nameof(ManufacturerId))]
        public virtual Manufacturer Manufacturer { get; set; }

        [Display(Name = nameof(ManufacturerId), ResourceType = typeof(Resources.PropertyNames))]
        public Guid ManufacturerId { get; set; }
    }
}
