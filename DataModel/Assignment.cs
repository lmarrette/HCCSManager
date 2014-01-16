using System;

namespace DataModel
{
   public class Assignment
   {
      public int Id { get; set; }
      public int EmployeeId { get; set; }
      public string WorkdayReferenceId { get; set; }
      public TrnType TrainingType { get; set; }
      public DateTime DateAssigned { get; set; }
   }

   public enum TrnType
   {
      Hire,
      Anniversary
   }
}
