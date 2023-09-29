using EmpManSys.BusinessLogic.DTOs;
namespace EmpManSys.BusinessLogic.Interfaces;

public interface IEmployeeService
{
    public IEnumerable<EmployeeDTO> GetAllEmployees();
    public EmployeeDTO GetEmployeeById(Guid employeeId);
    public EmployeeDTO AddEmployee(EmployeeDTO newEmployee);
    public EmployeeDTO UpdateEmployee(EmployeeDTO updatedEmployee);
    public void DeleteEmployee(Guid employeeId);
}
