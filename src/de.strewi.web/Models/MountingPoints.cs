using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models
{
    public enum MountingPoints : int
    {
		VerticalMountingPoints = 0,
		HonrizontalMountingPoints = 2,
		CrossMountingPoints = 4,
		SquareMountingPoints = 8,
		UpSideTriangleMountingPoints = 16,
		DownSideTriangleMountingPoints = 32
    }
}
