using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
	public class CrankAxle : BaseTimePeriodModel, IManufactureRelatedItem
	{
		public double Width { get; set; }
		public double ThreadDiameter { get; set; }
		public int ThreadPitch { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public virtual Manufacturer Manufacturer { get; set; }

        [Display(Name = nameof(ManufacturerId), ResourceType = typeof(Resources.PropertyNames))]
        public Guid ManufacturerId { get; set; }
    }
}
