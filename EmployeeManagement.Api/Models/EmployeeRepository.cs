﻿using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public AppDbContext AppDbContext { get; }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;            
        }

        public async void DeleteEmployee(int employeeId)
        {
            var result = await appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if(result != null)
            {
                appDbContext.Employees.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            var result = await appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            return (result);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var result = await appDbContext.Employees.ToListAsync();
            return result;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
            if(result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBrith = employee.DateOfBrith;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;

                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null; 
        }
    }
}
