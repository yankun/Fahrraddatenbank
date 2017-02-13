using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        [Required]
        public int MemberNumber { get; set; }

        public int Points { get; set; }

        public bool IsActivated { get; set; }

        public DateTime RegisteredAt { get; set; }
    }
}
