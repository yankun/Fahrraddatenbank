using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class ActivatedDevice
    {
        [Key]
        public int Id { get; set; }

        public int Code { get; set; }

        public Guid DeviceIdentifier { get; set; }

        public bool IsActivated { get; set; }

        public DateTime? ActivatedAt { get; set; }
    }
}
