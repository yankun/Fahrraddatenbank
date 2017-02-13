using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    public class Role : IdentityRole<Guid>
    {
        public const string ROLE_ADMIN = "Administrator";
        public const string ROLE_SUPERADMIN = "SuperAdministrator";
        public const string ROLE_MODERATOR = "Moderator";
        public const string ROLE_USER = "User";
    }
}
