using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public enum MountingPoints : int
    {
        None = 0,
		VerticalMountingPoints,
		HonrizontalMountingPoints,
		CrossMountingPoints,
		SquareMountingPoints,
		UpSideTriangleMountingPoints,
		DownSideTriangleMountingPoints
    }
}
