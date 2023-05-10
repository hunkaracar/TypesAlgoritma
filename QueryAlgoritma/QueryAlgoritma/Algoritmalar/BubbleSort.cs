using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryAlgoritma.Algoritmalar
{
    public class BubbleSort
    {
        public BubbleSort() 
        {

        }

        public void BubbleSortBySalary(Employee[] employees)
        {
            
            for (int i = 0; i < employees.Length; i++)
            {
                for (int j = 1; j <= employees.Length - 1; j++)
                {
                    if (employees[j-1].Salary > employees[j].Salary)
                    {
                        var Temp = employees[j-1];
                        employees[j-1] = employees[j];
                        employees[j] = Temp;
                    }
                }
            }
            foreach (var employee in employees)
            {
                //Genel olarak gösterir
                Console.WriteLine($"{employee.Id}: {employee.FirstName} {employee.LastName} - Salary: {employee.Salary}");

                //Sadece Maaşları BubbleSortAlgoritmasına göre sıralar
                //Console.WriteLine($"Salary => {employee.Salary}");
            }
        }
    }
}
