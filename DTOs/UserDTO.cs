using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.DTOs;

public class UserDTO
{
    public int Id { get; set; }

    public required string Username { get; set; }

    public required string Email { get; set; }

    public required string Password { get; set; }

    public string UserType { get; set; }

    public string AdminSpecificProperty { get; set; }

    public string EmployeeSpecificProperty { get; set; }
}
