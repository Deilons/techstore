using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.Models;

namespace techstore.DTOs;

public class OrderDTO
{
    public int Id { get; set; }
    
    public DateTime OrderDate { get; set; }

    public int Quantity { get; set; }

    public decimal TotalAmount { get; set; }

    public int ClientId { get; set; }

    public required List<int> ProductIds { get; set; }
}

