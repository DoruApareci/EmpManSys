using EmpManSys.BusinessLogic.DTOs;

namespace EmpManSys.BusinessLogic.Interfaces;

public interface IEmployeeEntryService
{
    EmployeeEntryDTO GetEmployeeEntryById(Guid EntryId);
    IEnumerable<EmployeeEntryDTO> GetAllEmployeeEntriesByUser(Guid userID);
    IEnumerable<EmployeeEntryDTO> GetAllEmployeeEntries();
    EmployeeEntryDTO AddEmployeeEntry(EmployeeEntryDTO employeeEntry);
}
