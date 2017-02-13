using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
	public abstract class BaseModel
	{
		[Key]
		public Guid Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public Guid? CreatedByID { get; set; }
		[ForeignKey(nameof(CreatedByID))]
		public virtual ApplicationUser CreatedBy { get; set; }
		public DateTime? ModifiedAt { get; set; }
		public Guid? ModifiedByID { get; set; }
		[ForeignKey(nameof(ModifiedByID))]
		public virtual ApplicationUser ModifiedBy { get; set; }

        public ModerationState ModerationState { get; set; }
	}
}
