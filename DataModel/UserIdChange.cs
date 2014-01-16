using System;

namespace DataModel
{
  public class UserIdChange
   {
      public int Id { get; set; }
      public int EmployeeId { get; set; }
      public string WorkdayReferenceId { get; set; }
      public string OldUserId { get; set; }
      public string NewUserId { get; set; }
      public DateTime DateSubmitted { get; set; }
   }
}
