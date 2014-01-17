using System.Data.Entity;
using DataModel;

namespace HCCSManager
{
   public class HccsContext : DbContext
   {
      public DbSet<EmployeeMaster> EmployeeMasters { get; set; }
      public DbSet<Assignment> Assignments { get; set; }
      public DbSet<Department> Departments { get; set; }
      public DbSet<FieldChange> FieldChanges { get; set; }
      public DbSet<NewHire> NewHires { get; set; }
      public DbSet<Termination> Terminations { get; set; }
      public DbSet<UserIdChange> UserIdChanges { get; set; }
      public DbSet<Staging> Stagings { get; set; }
   }
}