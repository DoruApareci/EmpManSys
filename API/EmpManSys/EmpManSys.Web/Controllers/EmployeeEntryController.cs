using EmpManSys.BusinessLogic.DTOs;
using EmpManSys.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmpManSys.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeEntryController : ControllerBase
{
    private readonly IEmployeeEntryService _employeeEntryService;

    public EmployeeEntryController(IEmployeeEntryService employeeEntryService)
    {
        _employeeEntryService = employeeEntryService;
    }

    [HttpGet]
    [Route("getAllEmployeesEntries")]
    public async Task<IActionResult> GetEmployeeEntries()
    {
        var employeeEntries = _employeeEntryService.GetAllEmployeeEntries();
        return Ok(employeeEntries);
    }
    [HttpGet]
    [Route("getAllEmployeesEntriesByUser")]
    public async Task<IActionResult> GetEmployeeEntriesByUser(Guid userID)
    {
        var employeeEntries = _employeeEntryService.GetAllEmployeeEntriesByUser(userID);
        return Ok(employeeEntries);
    }
    [HttpGet]
    [Route("getEmployeeEntryById")]
    public async Task<IActionResult> GetEmployeeEntryById(Guid id)
    {
        var employeeEntry = _employeeEntryService.GetEmployeeEntryById(id);
        return Ok(employeeEntry);
    }
    [HttpPost]
    [Route("addEmployeeEntry")]
    public async Task<IActionResult> AddEmployeeEntry(EmployeeEntryDTO employeeEntry)
    {
        var createdEmployeeEntry = _employeeEntryService.AddEmployeeEntry(employeeEntry);//this is where we need to add the logic
        return Ok(createdEmployeeEntry);
    }
}
