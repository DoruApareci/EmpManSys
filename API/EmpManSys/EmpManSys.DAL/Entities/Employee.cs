using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManSys.DAL.Entities;

public class Employee
{
    [Key]
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Surename { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime EmploymentDate { get; set; }
    public string PhoneNr { get; set; }
    public string IDNP { get; set; }
    public string Function { get; set; }
}