using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    [Flags]
    public enum HeadbadgeMaterial : int
    {
        [Display(Name = nameof(Unknown), ResourceType = typeof(Resources.EnumNames))]
        Unknown = 0,
        [Display(Name = nameof(Decal), ResourceType = typeof(Resources.EnumNames))]
        Decal = 1,
        [Display(Name = nameof(Etching), ResourceType = typeof(Resources.EnumNames))]
        Etching = 2,
        [Display(Name = nameof(Brass), ResourceType = typeof(Resources.EnumNames))]
        Brass = 4,
        [Display(Name = nameof(Alloy), ResourceType = typeof(Resources.EnumNames))]
        Alloy = 8,
        [Display(Name = nameof(ZincDieCast), ResourceType = typeof(Resources.EnumNames))]
        ZincDieCast = 16
    }
}
