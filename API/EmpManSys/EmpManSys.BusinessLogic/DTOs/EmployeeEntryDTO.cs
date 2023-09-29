using EmpManSys.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManSys.BusinessLogic.DTOs;

public class EmployeeEntryDTO
{
    public Guid ID { get; set; }
    public DateTime EntryTime { get; set; }
    public bool IsEntry { get; set; } = true;

    public Guid EmployeeID { get; set; }

    public EmployeeEntryDTO()
    {
        ID = Guid.NewGuid();
        EntryTime = new DateTime();
        IsEntry = true;
        EmployeeID = Guid.NewGuid();
    }
    public EmployeeEntryDTO(EmployeeEntry employeeEntry)
    {
        ID = employeeEntry.ID;
        EntryTime = employeeEntry.EntryTime;
        IsEntry = employeeEntry.IsEntry;
        EmployeeID = employeeEntry.EmployeeID;
    }

    public static EmployeeEntry ToEmployeeEntry(EmployeeEntryDTO employeeEntryDTO)
    {
        return new EmployeeEntry
        {
            ID = employeeEntryDTO.ID,
            EntryTime = employeeEntryDTO.EntryTime,
            IsEntry = employeeEntryDTO.IsEntry,
            EmployeeID = employeeEntryDTO.EmployeeID,
        };
    }
}
