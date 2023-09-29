using EmpManSys.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmpManSys.DAL;

public class AppDbContext : DbContext
{
    #region Configurations
    private readonly string? _connectionString;

    public AppDbContext(string? connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
            throw new ArgumentNullException(nameof(connectionString));

        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder opBuilder)
    {
        opBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    #endregion
    #region Entities
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeEntry> EmployeeEntries { get; set; }
    #endregion
}
