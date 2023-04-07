using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Advanced_Topics_in_C_Sharp_Lab05.Models;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

namespace Advanced_Topics_in_C_Sharp_Lab05.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Advanced_Topics_in_C_Sharp_Lab05User class
public class ApplicationUser : IdentityUser
{
    [Required(AllowEmptyStrings = false)]
    [Display(Name = "Full Name")]
    public string FullName { get; set; } = default!;

    public HashSet<BankAccount> BankAccounts { get; set; } = new HashSet<BankAccount>();
}

