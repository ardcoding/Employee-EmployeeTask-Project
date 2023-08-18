using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using OfficeDb.Entities;

public class OfficeDbContext : DbContext
{ 
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeTask> EmployeeTasks { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Database=OfficeDb;Integrated Security=True;;Encrypt=False;Trust Server Certificate=False;");
    }
}

class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}