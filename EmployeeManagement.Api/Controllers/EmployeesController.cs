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
    //The API project is the one provides the REST endpoint 
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
            //Check if the Email is already used 
            var emp = await employeeRepository.GetEmployeeByEmail(employee.Email);
            if(emp != null)
            {
                ModelState.AddModelError("email", "Employee Email already in use");
                return BadRequest(ModelState);
            }
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

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            try
            {
                // first, we compare passing id against the id in employee object
                if(id != employee.EmployeeId)
                {
                    return BadRequest("Emp Id missmatch");
                }
                // also, check if the employee is in the system..
                var emp =   await employeeRepository.GetEmployee(id);
                if(emp == null)
                {
                    return NotFound($"Employee with Id: {id} not found!");
                }
                //Okay, all good so far.. update the record
                var updatedEmp =  await employeeRepository.UpdateEmployee(employee);
                return (updatedEmp);
            }
            catch (Exception)            
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Updating new Emp..");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {
                var emp = await employeeRepository.GetEmployee(id); 
                if(emp == null)
                {
                    return NotFound($"Employee with Id: {id} not found!");
                }
                var delEmp = await employeeRepository.DeleteEmployee(emp.EmployeeId);
                return delEmp;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error Deleting the Emp..");
            }

        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Employee>>> Search(string name, Gender? gender)
        {
            try
            {
                var result = await employeeRepository.Search(name, gender);
                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error Searching the Emp..");
            }
        }
    }
}
