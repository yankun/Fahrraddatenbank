using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class Framenumber : BaseModel, IManufactureRelatedItem
    {
        public int Number { get; set; }

        public int Year { get; set; }

        public FrameNumberProof ProvenBy { get; set; }
        
        [Required]
        [ForeignKey(nameof(ManufacturerId))]
        public Manufacturer Manufacturer { get; set; }

        public Guid ManufacturerId { get; set; }

        [MaxLength(3000)]
        public string Comment { get; set; }
    }
}
