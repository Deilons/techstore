using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;

public class Client
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
    [StringLength(15)]
    public string Phone { get; set; }

    [StringLength(255)]
    public string Address { get; set; }

    public ICollection<Order> Orders { get; set; }
}

