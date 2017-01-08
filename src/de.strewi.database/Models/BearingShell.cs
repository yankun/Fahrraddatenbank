using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
	public class BearingShell : BaseTimePeriodModel, IManufactureRelatedItem
	{
		public string Image { get; set; }
		public double Depth { get; set; }
		public double OuterDiamteter { get; set; }
		public double InnerDiameter { get; set; }
		public double CrankHoleDiameter { get; set; }
		public Side Side { get; set; }
		public BearingShellPosition Position { get; set; }
		public bool IsThreaded { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public virtual Manufacturer Manufacturer { get; set; }

        [Display(Name = nameof(ManufacturerId), ResourceType = typeof(Resources.PropertyNames))]
        public Guid ManufacturerId { get; set; }
    }
}
