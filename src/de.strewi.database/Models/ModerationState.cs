using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public enum ModerationState : int
    {
        New = 0,
        Edited,
        Rejected,
        Accpeted
    }
}
