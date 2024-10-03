using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;

[Table("products")]
public class Product
{   
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(30, ErrorMessage = "Name cannot be longer than 100 characters.")]
    public string Name { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "Description cannot be longer than 100 characters.")]
    public string Description { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }

    public string CategoryId{ get; set; }
    public Category Category { get; set; }

    public ICollection<Order> Orders { get; set; }


}
