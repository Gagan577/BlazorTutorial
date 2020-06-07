using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public interface IDepartmentRepository
    {
        //old version before converting to returning Task - service ***BEGINS
        //IEnumerable<Department> GetDepartments();
        //Department GetDepartment(int departmentId);
        //old version before converting to returning Task - service ***ENDS
        Task<IEnumerable<Department>> GetDepartments();
        Task <Department> GetDepartment(int departmentId);
    }
}
