using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models
{
    public class HeadBadge : ManufactureRelatedItem
    {
		public string Image { get; set; }

		public DateTime ValidForm { get; set; }

		public DateTime ValidTo { get; set; }

		public double HorizontalDistance { get; set; }

		public double VerticalDistance { get; set; }

		public string Notes { get; set; }

		public MountingPoints MountingPoints { get; set; }
    }
}
