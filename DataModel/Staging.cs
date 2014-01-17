using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel
{
  public class Staging
   {
      public int Id { get; set; }
      public string WorkdayId { get; set; }
      public string UserId { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string WorkEmail { get; set; }
      public DateTime HireDate { get; set; }
      public string Department { get; set; }
      public string ManagementLevel { get; set; }
   }
}
