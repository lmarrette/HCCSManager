using System;

namespace DataModel
{
  public class Termination
   {
      public int Id { get; set; }
      public int EmployeeId { get; set; }
      public string WorkdayReferenceId { get; set; }
      public DateTime DateSubmitted { get; set; }
   }
}
