using System;
using System.Collections.Generic;

namespace DataModel
{
   public class EmployeeMaster
   {
      public int Id { get; set; }
      public string WorkdayId { get; set; }
      public string UserId { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string WorkEmail { get; set; }
      public DateTime HireDate { get; set; }
      public Department Department { get; set; }
      public string ManagementLevel { get; set; }
      public string Status { get; set; }
      public DateTime? TerminationDate { get; set; }
      public DateTime? LastChangeDate { get; set; }
      public DateTime InitialLoadDate { get; set; }
      public DateTime? NextTrainDate { get; set; }
      public string LastTransactionType { get; set; }
      public List<Assignment> Assignments { get; set; }
      
      public EmployeeMaster()
      {
         Assignments = new List<Assignment>();
      }
   }
}
