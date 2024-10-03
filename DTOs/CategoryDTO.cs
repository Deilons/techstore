using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.DTOs;

public class CategoryDTO
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public required List<int> ProductIds { get; set; } 
}

