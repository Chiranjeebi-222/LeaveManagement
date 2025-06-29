using LeaveManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;


public class LeaveDbContext : DbContext
{
    public LeaveDbContext(DbContextOptions<LeaveDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<LeaveType>().HasData(
            new LeaveType { TypeID = 1, TypeName = "Sick" },
            new LeaveType { TypeID = 2, TypeName = "Personal" },
            new LeaveType { TypeID = 3, TypeName = "Emergency" }
        );
    }
}
