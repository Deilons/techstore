using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;

    public class User
{
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(50)]
    public string Email { get; set; }

    [Required]
    [StringLength(20)]
    public string Role { get; set; }

    public Admin AdminDetails { get; set; }
    public Employee EmployeeDetails { get; set; }
}

