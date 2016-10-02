using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models
{
    public abstract class ManufactureRelatedItem : BaseModel
    {
		[ForeignKey(nameof(ManufactureId))]
		public virtual Manufacture Manufacture { get; set; }

		public int ManufactureId { get; set; }
	}
}
