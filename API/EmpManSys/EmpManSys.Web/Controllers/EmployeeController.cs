using EmpManSys.BusinessLogic.DTOs;
using EmpManSys.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmpManSys.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
         _employeeService = employeeService;
    }

    [HttpGet]
    [Route("getEmployees")]
    public async Task<IActionResult> GetEmployees()
    {
        var employees = _employeeService.GetAllEmployees();
        return Ok(employees);
    }

    [HttpGet]
    [Route("getEmployeesByPage")]
    public async Task<IActionResult> GetEmployeesPaged(int count, int page)
    {
        var employees = _employeeService.GetAllEmployees().Skip(count*(page-1)).Take(count);
        return Ok(employees);
    }

    [HttpGet]
    [Route("getEmployeeById")]
    public async Task<IActionResult> GetEmployeeById(Guid id)
    {
        var employee = _employeeService.GetEmployeeById(id);
        return Ok(employee);
    }

    [HttpPost]
    [Route("registerNewEmployee")]
    public async Task<IActionResult> CreateEmployee(EmployeeDTO employee)
    {
        var createdEmployee = _employeeService.AddEmployee(employee);
        return Ok(createdEmployee);
    }

    [HttpPut]
    [Route("updateEmployee")]
    public async Task<IActionResult> UpdateEmployee(EmployeeDTO employee)
    {
        var updatedEmployee = _employeeService.UpdateEmployee(employee);
        return Ok(updatedEmployee);
    }

    [HttpDelete]
    [Route("deleteEmployee")]
    public async Task<IActionResult> DeleteEmployee(Guid id)
    {
        _employeeService.DeleteEmployee(id);
        return Ok();
    }
}
