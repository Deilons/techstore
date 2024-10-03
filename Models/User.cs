using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;

[Table("user")]
public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "Name must be between 3 and 30 characters long.", MinimumLength = 3)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(50, ErrorMessage = "Email must be between 3 and 50 characters long.", MinimumLength = 3)]
    public string Email { get; set; }

    [Required]
    [StringLength(20)]
    public string Role { get; set; }

    public Admin AdminDetails { get; set; }
    public Employee EmployeeDetails { get; set; }
}

