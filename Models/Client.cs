using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;

[Table("clients")]
public class Client
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
    [StringLength(15, ErrorMessage = "Phone must be between 3 and 15 characters long.", MinimumLength = 3)]
    public string Phone { get; set; }

    [Required]
    [StringLength(255, ErrorMessage = "Address must be between 3 and 255 characters long.", MinimumLength = 3)]
    public string Address { get; set; }

    public ICollection<Order> Orders { get; set; }
}

