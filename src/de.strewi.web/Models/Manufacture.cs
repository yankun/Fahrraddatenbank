using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models
{
	public class Manufacturer : BaseModel
	{
		[Display(Name = nameof(Name), ResourceType = typeof(Resources.PropertyNames))]
		[MaxLength(255, ErrorMessage = "Der Name des Herstellers darf maximal 255 Zeichen lang sein")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Der Name des Herstellers ist der Pflichtfeld.")]
		public string Name { get; set; }

		[Display(Name = nameof(City), ResourceType = typeof(Resources.PropertyNames))]
		[MaxLength(255, ErrorMessage = "Der Name der Stadt darf maximal 255 Zeichen lang sein.")]
		public string City { get; set; }

		[Display(Name = nameof(FoundedAt), ResourceType = typeof(Resources.PropertyNames))]
		public DateTime FoundedAt { get; set; }

		[Display(Name = nameof(StoppedProductionAt), ResourceType = typeof(Resources.PropertyNames))]
		public DateTime StoppedProductionAt { get; set; }

		[Display(Name = nameof(OvertakenById), ResourceType = typeof(Resources.PropertyNames))]
		public int? OvertakenById { get; set; }

		[ForeignKey(nameof(OvertakenById))]
		public Manufacturer OvertakenBy { get; set; }

		[Display(Name = nameof(OvertakenAt), ResourceType = typeof(Resources.PropertyNames))]
		public DateTime? OvertakenAt { get; set; }

		[Column(TypeName = "ntext")]
		[DataType(DataType.MultilineText)]
		[Display(Name = nameof(History), ResourceType = typeof(Resources.PropertyNames))]
		public string History { get; set; }
	}
}
