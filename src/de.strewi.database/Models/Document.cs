using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class Document : IManufactureRelatedItem
    {
        [MaxLength(255, ErrorMessageResourceName = nameof(Resources.ErrorMessages.GenericLengthError), ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string OCRContent { get; set; }

        [Required]
        [ForeignKey(nameof(ManufacturerId))]
        public Manufacturer Manufacturer { get; set; }

        public Guid ManufacturerId { get; set; }
    }
}
