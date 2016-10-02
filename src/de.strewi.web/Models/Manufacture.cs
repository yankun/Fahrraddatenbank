using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models
{
	public class Manufacture : BaseModel
	{
		public string Name { get; set; }

		public string City { get; set; }

		public string Country { get; set; }

		public DateTime FoundedAt { get; set; }
	}
}
