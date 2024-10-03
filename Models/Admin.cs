using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;

public class Admin : User
{
    [Required]
    public string AdminPrivileges { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}