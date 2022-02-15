using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebManager.Models.Identity
{
    public class AppUser : IdentityUser
    {
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string UrlImage { get; set; }
    }
}
