using System;

namespace DataModel
{
  public class FieldChange
   {
      public int Id { get; set; }
      public int EmployeeId { get; set; }
      public string WorkdayReferenceId { get; set; }
      public string UserId { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string WorkEmail { get; set; }
      public DateTime HireDate { get; set; }
      public Department Department { get; set; }
      public string ManagementLevel { get; set; }
      public DateTime DateSubmitted { get; set; }
   }
}
