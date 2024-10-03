using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.DTOs;

public class ProductDTO
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required int Quantity { get; set; }
    public required int CategoryId { get; set; }
}
