using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class HeadBadge : ManufactureRelatedItem
    {
		public string Image { get; set; }

		[Display(Name = nameof(ValidFrom), ResourceType = typeof(Resources.PropertyNames))]
		public DateTime? ValidFrom { get; set; }

		[Display(Name = nameof(ValidTo), ResourceType = typeof(Resources.PropertyNames))]
		public DateTime? ValidTo { get; set; }

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
    }
}
