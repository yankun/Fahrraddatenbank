using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public interface IManufactureRelatedItem
    {
		[ForeignKey(nameof(ManufacturerId))]
		Manufacturer Manufacturer { get; set; }

		[Display(Name = nameof(ManufacturerId), ResourceType = typeof(Resources.PropertyNames))]
		Guid ManufacturerId { get; set; }
	}
}
