using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryAlgoritma.Algoritmalar
{
    public class QuickSort
    {
        public QuickSort()
        {

        }

        public void QuickSortBySalary(Employee[] employees)
        {
            QuickSortBySalaryy(employees,0,employees.Length-1);

            foreach (var employee in employees)
            {
                //Genel Gösterir.
                Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName} -Salary: {employee.Salary}");

                //Salary'e göre gösterir.
                //Console.WriteLine($"{employee.Salary}");
            }
        }

        private void QuickSortBySalaryy(Employee[] employees, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionBySalary(employees, low, high);
                QuickSortBySalaryy(employees, low, pivotIndex - 1);
                QuickSortBySalaryy(employees, pivotIndex + 1, high);
            }
        }

        private int PartitionBySalary(Employee[] employees, int low, int high)
        {
            Employee pivot = employees[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (employees[j].Salary < pivot.Salary)
                {
                    i++;
                    SwapEmployees(employees, i, j);
                }
            }

            SwapEmployees(employees, i + 1, high);
            return i + 1;
        }

        private void SwapEmployees(Employee[] employees, int i, int j)
        {
            Employee temp = employees[i];
            employees[i] = employees[j];
            employees[j] = temp;
        }
    }
}
