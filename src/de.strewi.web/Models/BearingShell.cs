using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models
{
	public class BearingShell : ManufactureRelatedItem
	{
		public string Image { get; set; }
		public double Depth { get; set; }
		public double OuterDiamteter { get; set; }
		public double InnerDiameter { get; set; }
		public double CrankHoleDiameter { get; set; }
		public Side Side { get; set; }
		public BearingShellPosition Position { get; set; }
		public bool IsThreaded { get; set; }
	}
}
