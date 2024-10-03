using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace techstore.Models;


public class Employee : User
{
    [Required]
    public DateTime HireDate { get; set; }
    public string Department { get; set; }
}
