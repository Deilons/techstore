using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;

[Table("admin")]
public class Admin : User
{
    [Required]
    public string AdminPrivileges { get; set; }
    public User User { get; set; } 
}

