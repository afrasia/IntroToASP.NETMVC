using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IntroToASP.NETMVC.Models
{
    public class LoginInformationModel
    {
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string EmailAddress
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        [BindProperty(Name = "pass")]
        public string Password
        {
            get;
            set;
        }
    }
}
