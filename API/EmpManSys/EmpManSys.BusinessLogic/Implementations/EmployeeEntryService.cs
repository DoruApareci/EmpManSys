using EmpManSys.BusinessLogic.DTOs;
using EmpManSys.BusinessLogic.Interfaces;
using EmpManSys.DAL;

namespace EmpManSys.BusinessLogic.Implementations;

public class EmployeeEntryService : IEmployeeEntryService
{
    private readonly AppDbContext _appDbContext;
    public EmployeeEntryService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public EmployeeEntryDTO AddEmployeeEntry(EmployeeEntryDTO employeeEntry)
    {
        //var isEntry = !_appDbContext.EmployeeEntries.Where(x => x.EmployeeID == employeeEntry.ID).Last().IsEntry;
        //_appDbContext.EmployeeEntries.Add(EmployeeEntryDTO.ToEmployeeEntry(employeeEntry));
        //_appDbContext.SaveChanges();
        //======================================================================
        //WE NEED A CUSTOM LOGIC TO CHECK IF THE LAST ENTRY IS AN ENTRY OR EXIT
        //======================================================================
        return employeeEntry;
    }

    public IEnumerable<EmployeeEntryDTO> GetAllEmployeeEntries()
    {
        return _appDbContext.EmployeeEntries.Select(x => new EmployeeEntryDTO(x));
    }

    public IEnumerable<EmployeeEntryDTO> GetAllEmployeeEntriesByUser(Guid userID)
    {
        return _appDbContext.EmployeeEntries.Where(x => x.EmployeeID == userID).Select(x => new EmployeeEntryDTO(x));
    }

    public EmployeeEntryDTO GetEmployeeEntryById(Guid EntryId)
    {
        var empEntry = _appDbContext.EmployeeEntries.FirstOrDefault(x => x.ID == EntryId);
        if (empEntry != null)
        {
            return new EmployeeEntryDTO(empEntry);
        }
        return null;
    }
}
