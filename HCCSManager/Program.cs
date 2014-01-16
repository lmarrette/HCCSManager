using DataModel;

namespace HCCSManager
{
   class Program
   {
      static void Main()
      {
         var dpt = new Department();
         dpt.DepartmentName = "New Department";
         dpt.WorkdayReferenceId = "ksk82ks8";

         using (var context = new HccsContext())
         {
            context.Departments.Add(dpt);
            context.SaveChanges();
         }
      }
   }
}
