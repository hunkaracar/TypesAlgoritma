
using static QueryAlgoritma.Option;

namespace QueryAlgoritma
{
    class Program
    {
        public static void Main()
        {
            Option option = new Option();

            dbContext db = new dbContext();

            option.Choose_opt();

            /*
            using (var dbContext = new dbContext())
            {
                var employees = dbContext.Employees.ToList();
                
                //VeriTabanındaki değerleri çeker ve Console'da görüntüleriz.
                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.Id}: {employee.FirstName} {employee.LastName} - Salary: {employee.Salary}");
                }
            }
            */




        }
    }
}
