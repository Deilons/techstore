using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using techstore.Models;

namespace techstore.Repositories
{
    public interface IEmpleoyeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Add(Employee Empleoyee);
        Task<Employee> Update(Employee Empleoyee);
        Task<Employee> Delete(int id);
    }
}