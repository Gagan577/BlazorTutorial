using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase 
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeesController(IEmployeeRepository  employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                var result = await employeeRepository.GetEmployees();
                return Ok(result); // Ok is 200 http return
            }
            catch (Exception)
            {             
                return StatusCode(StatusCodes.Status500InternalServerError, "Error getting data from DB..");
            }            
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int Id)
        {
            try
            {
                var result = await employeeRepository.GetEmployee(Id);
                //return Ok(result);
                if(result == null)
                {
                    return NotFound();
                }
                else
                {
                    return result;
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error getting data from DB..");
            }
        }
        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Adding new Emp..");
            }
            try
            {
                var result = await employeeRepository.AddEmployee(employee);
                //return StatusCode(StatusCodes.Status201Created, "A new Emp is added..");
                return CreatedAtAction(nameof(GetEmployeeById), new { id = result.EmployeeId}, result);
            }
            catch (Exception)

            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Adding new Emp..");
            }
        }
    }
}
