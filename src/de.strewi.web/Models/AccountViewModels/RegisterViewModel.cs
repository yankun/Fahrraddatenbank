using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace de.strewi.web.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessageResourceName = "MinMaxLength", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [Display(Name = nameof(Username), ResourceType = typeof(Resources.PropertyNames))]
        public string Username { get; set; }

        [Required]
        [Display(Name = nameof(MemberNumber), ResourceType = typeof(Resources.PropertyNames))]
        public int MemberNumber { get; set; }

        [StringLength(100, ErrorMessageResourceName = "MinMaxLength", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [Display(Name = nameof(Firstname), ResourceType = typeof(Resources.PropertyNames))]
        public string Firstname { get; set; }

        [StringLength(100, ErrorMessageResourceName = "MinMaxLength", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [Display(Name = nameof(Lastname), ResourceType = typeof(Resources.PropertyNames))]
        public string Lastname { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessageResourceName = "MinMaxLength", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataType(DataType.Password)]
        [Display(Name = nameof(Password), ResourceType = typeof(Resources.PropertyNames))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = nameof(ConfirmPassword), ResourceType = typeof(Resources.PropertyNames))]
        [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
