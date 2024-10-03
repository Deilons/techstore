using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techstore.DTOs;

public class EmployeeDTO : UserDTO
{
    public DateTime HireDate { get; set; }

    public string Department { get; set; }
}

