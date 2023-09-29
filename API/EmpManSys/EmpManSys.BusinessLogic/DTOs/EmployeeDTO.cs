using EmpManSys.DAL.Entities;

namespace EmpManSys.BusinessLogic.DTOs;

public class EmployeeDTO
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Surename { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime EmploymentDate { get; set; }
    public string PhoneNr { get; set; }
    public string IDNP { get; set; }
    public string Function { get; set; } = string.Empty;

    public EmployeeDTO()
    {
        ID = Guid.NewGuid();
        Name = string.Empty;
        Surename = string.Empty;
        BirthDate = new DateTime();
        EmploymentDate = new DateTime();
        PhoneNr = string.Empty;
        IDNP = string.Empty;
        Function = string.Empty;
    }
    public EmployeeDTO(Employee employee)
    {
        ID = employee.ID;
        Name = employee.Name;
        Surename = employee.Surename;
        BirthDate = employee.BirthDate;
        EmploymentDate = employee.EmploymentDate;
        PhoneNr = employee.PhoneNr;
        IDNP = employee.IDNP;
        Function = employee.Function;
    }

    public static Employee ToEmployee(EmployeeDTO employeeDTO)
    {
        return new Employee
        {
            ID = employeeDTO.ID,
            Name = employeeDTO.Name,
            Surename = employeeDTO.Surename,
            BirthDate = employeeDTO.BirthDate,
            EmploymentDate = employeeDTO.EmploymentDate,
            PhoneNr = employeeDTO.PhoneNr,
            IDNP = employeeDTO.IDNP,
            Function = employeeDTO.Function
        };
    }
}
