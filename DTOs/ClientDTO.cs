using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.DTOs;

public class ClientDTO
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Address { get; set; }


}
