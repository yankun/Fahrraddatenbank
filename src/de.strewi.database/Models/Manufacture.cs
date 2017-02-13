using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    /// <summary>
    /// The basic manufacturer
    /// </summary>
	public class Manufacturer : BaseModel
	{
        private string foundedAt;
        private string stoppedProductionAt;
        private string overtakenAt;

		[Display(Name = nameof(Name), ResourceType = typeof(Resources.PropertyNames))]
		[MaxLength(255, ErrorMessage = "Der Name des Herstellers darf maximal 255 Zeichen lang sein")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Der Name des Herstellers ist der Pflichtfeld.")]
		public string Name { get; set; }

		[Display(Name = nameof(City), ResourceType = typeof(Resources.PropertyNames))]
		[MaxLength(255, ErrorMessage = "Der Name der Stadt darf maximal 255 Zeichen lang sein.")]
		public string City { get; set; }

		[Display(Name = nameof(FoundedAt), ResourceType = typeof(Resources.PropertyNames))]
        public string FoundedAt
        {
            get
            {
                return overtakenAt;
            }
            set
            {
                int? validFrom, validTo;

                TimeEstimateParser.ParseTimeEstimate(value, out validFrom, out validTo);

                FoundedAtValidFrom = validFrom;
                FoundedAtValidTo = validTo;
                overtakenAt = value;
            }
        }

        public int? FoundedAtValidFrom { get; private set; }
        public int? FoundedAtValidTo { get; private set; }

        [Display(Name = nameof(StoppedProductionAt), ResourceType = typeof(Resources.PropertyNames))]
        public string StoppedProductionAt
        {
            get
            {
                return overtakenAt;
            }
            set
            {
                int? validFrom, validTo;

                TimeEstimateParser.ParseTimeEstimate(value, out validFrom, out validTo);

                StoppedProductionAtValidFrom = validFrom;
                StoppedProductionAtValidTo = validTo;
                overtakenAt = value;
            }
        }

        public int? StoppedProductionAtValidFrom { get; private set; }
        public int? StoppedProductionAtValidTo { get; private set; }

        [Display(Name = nameof(OvertakenById), ResourceType = typeof(Resources.PropertyNames))]
		public Guid? OvertakenById { get; set; }

		[ForeignKey(nameof(OvertakenById))]
		public Manufacturer OvertakenBy { get; set; }

		[Display(Name = nameof(OvertakenAt), ResourceType = typeof(Resources.PropertyNames))]
        public string OvertakenAt
        {
            get
            {
                return overtakenAt;
            }
            set
            {
                int? validFrom, validTo;

                TimeEstimateParser.ParseTimeEstimate(value, out validFrom, out validTo);

                OvertakenAtValidFrom = validFrom;
                OvertakenAtValidTo = validTo;
                overtakenAt = value;
            }
        }

        public int? OvertakenAtValidFrom { get; private set; }
        public int? OvertakenAtValidTo { get; private set; }

        public ManufacturerType Type { get; set; }

		[Column(TypeName = "ntext")]
		[DataType(DataType.MultilineText)]
		[Display(Name = nameof(History), ResourceType = typeof(Resources.PropertyNames))]
		public string History { get; set; }
	}
}
