using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class ValueChange
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string PropertyName { get; set; }

        public string NewValue { get; set; }

        [Required]
        public string EntityName { get; set; }

        [Required]
        public Guid ItemId;

        [Required]
        public Guid GroupId;

        [Required]
        public DateTime ChangedAt;
    }
}
