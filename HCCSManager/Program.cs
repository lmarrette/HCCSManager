using System;
using System.Runtime.Remoting.Contexts;
using DataModel;
using HCCSManager.WorkdayHCCS;
using WdConnect;

namespace HCCSManager
{
   class Program
   {
      static void Main()
      {
         var wdc = new WorkdayConnection();
         var client = new ReportPortClient("Report");
         if (client.ClientCredentials != null)
         {
            client.ClientCredentials.UserName.UserName = wdc.UserName;
            client.ClientCredentials.UserName.Password = wdc.UserPw;
         }
         var request = new Execute_ReportType();
         Report_EntryType[] response = client.Execute_Report(request);
         try
         {
            foreach (Report_EntryType t in response)
            {
               var st = new Staging();
               st.UserId = t.userName;
               st.FirstName = t.firstName;
               st.LastName = t.lastName;
               st.Department.WorkdayReferenceId = t.department.ID[0].Value;
               st.HireDate = t.hireDate;
               st.ManagementLevel = t.ManagementLevel.Descriptor;
               st.WorkEmail = t.workEmail11;
               st.WorkdayId = t.EmployeeID;
               using (var context = new HccsContext())
               {
                  context.Stagings.Add(st);
                  context.SaveChanges();
               }
            }
         }
         catch (Exception)
         {
            
            throw;
         }
      }
      }
   }

