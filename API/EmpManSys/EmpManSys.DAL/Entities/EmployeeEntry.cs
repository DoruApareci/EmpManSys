using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManSys.DAL.Entities;

public class EmployeeEntry
{
    [Key]
    public Guid ID { get; set; }
    public DateTime EntryTime { get; set; }
    public bool IsEntry { get; set; } = true;

    [ForeignKey(nameof(Employee))]
    public Guid EmployeeID { get; set; }
    public Employee Employee { get; set; }
}
