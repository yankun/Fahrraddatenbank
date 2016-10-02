using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models
{
	public class CrankAxle : ManufactureRelatedItem
	{
		public double Width { get; set; }
		public double ThreadDiameter { get; set; }
		public int ThreadPitch { get; set; }
	}
}
