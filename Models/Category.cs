using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;

[Table("categories")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "Name must be between 3 and 30 characters long.", MinimumLength = 3)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(100, ErrorMessage = "Description must be between 3 and 100 characters long.", MinimumLength = 3)]
    public string Description { get; set; }

    public ICollection<Product> Products { get; set; }
}

