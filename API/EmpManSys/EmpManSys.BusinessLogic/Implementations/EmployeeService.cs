using EmpManSys.BusinessLogic.DTOs;
using EmpManSys.BusinessLogic.Interfaces;
using EmpManSys.DAL;

namespace EmpManSys.BusinessLogic.Implementations;

public class EmployeeService : IEmployeeService
{
    private readonly AppDbContext _appDbContext;

    public EmployeeService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public EmployeeDTO AddEmployee(EmployeeDTO newEmployee)
    {
        _appDbContext.Employees.Add(EmployeeDTO.ToEmployee(newEmployee));
        _appDbContext.SaveChanges();
        return newEmployee;
    }

    public void DeleteEmployee(Guid employeeId)
    {
        var employee = _appDbContext.Employees.FirstOrDefault(e => e.ID == employeeId);
        if (employee != null)
        {
            _appDbContext.Employees.Remove(employee);
            _appDbContext.SaveChanges();
        }
    }

    public IEnumerable<EmployeeDTO> GetAllEmployees()
    {
        return _appDbContext.Employees.Select(x => new EmployeeDTO(x));
    }

    public EmployeeDTO GetEmployeeById(Guid employeeId)
    {
        var employee = _appDbContext.Employees.FirstOrDefault(e => e.ID == employeeId);
        if (employee != null)
        {
            return new EmployeeDTO(employee);
        }
        return null;
    }

    public EmployeeDTO UpdateEmployee(EmployeeDTO updatedEmployee)
    {
        var emp = EmployeeDTO.ToEmployee(updatedEmployee);
        var employee = _appDbContext.Employees.FirstOrDefault(e => e.ID == emp.ID);
        if (employee != null)
        {
            employee.ID = emp.ID;
            employee.Name = emp.Name;
            employee.Surename = emp.Surename;
            employee.BirthDate = emp.BirthDate;
            employee.EmploymentDate = emp.EmploymentDate;
            employee.PhoneNr = emp.PhoneNr;
            employee.IDNP = emp.IDNP;
            employee.Function = emp.Function;
            _appDbContext.Employees.Update(employee);
            _appDbContext.SaveChanges();
            return updatedEmployee;
        }
        return null;
    }
}