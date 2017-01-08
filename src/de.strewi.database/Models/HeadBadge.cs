using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class HeadBadge : BaseTimePeriodModel, IManufactureRelatedItem
    {
		public string Image { get; set; }

		[Display(Name = nameof(HorizontalDistance), ResourceType = typeof(Resources.PropertyNames))]
		public double? HorizontalDistance { get; set; }

		[Display(Name = nameof(VerticalDistance), ResourceType = typeof(Resources.PropertyNames))]
		public double? VerticalDistance { get; set; }

		[MaxLength(500, ErrorMessageResourceName = "NotesErrorMessage", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
		[Display(Name = nameof(Notes), ResourceType = typeof(Resources.PropertyNames))]
		public string Notes { get; set; }

		[Display(Name = nameof(UsedColors), ResourceType = typeof(Resources.PropertyNames))]
		public string UsedColors { get; set; }

		[Display(Name = nameof(MountingPoints), ResourceType = typeof(Resources.PropertyNames))]
		public MountingPoints MountingPoints { get; set; }

        [Display(Name = nameof(NumberOfMountingPoints), ResourceType = typeof(Resources.PropertyNames))]
        public int? NumberOfMountingPoints { get; set; }

        [Display(Name = nameof(HeadbadgeMaterial), ResourceType = typeof(Resources.PropertyNames))]
        public HeadbadgeMaterial HeadbadgeMaterial { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public virtual Manufacturer Manufacturer { get; set; }

        [Display(Name = nameof(ManufacturerId), ResourceType = typeof(Resources.PropertyNames))]
        public Guid ManufacturerId { get; set; }
    }
}
