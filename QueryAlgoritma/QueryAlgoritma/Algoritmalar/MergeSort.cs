using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryAlgoritma.Algoritmalar
{
    public class MergeSort
    {
        public MergeSort()
        {

        }

        public void MergeSortByLastName(Employee[] employees)
        {
            MergeSortByLastName(employees, 0, employees.Length - 1);

            foreach (var employee in employees)
            {
                //Genel gösterir
                Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName} -Salary: {employee.Salary}");

                //LastName Sırası
                //Console.WriteLine($"{employee.LastName}");
            }
        }

        private void MergeSortByLastName(Employee[] employees, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortByLastName(employees, left, mid);
                MergeSortByLastName(employees, mid + 1, right);
                Merge(employees, left, mid, right);
            }
        }

        private void Merge(Employee[] employees, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            Employee[] leftArray = new Employee[n1];
            Employee[] rightArray = new Employee[n2];

            Array.Copy(employees, left, leftArray, 0, n1);
            Array.Copy(employees, mid + 1, rightArray, 0, n2);

            int i = 0;
            int j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (string.Compare(leftArray[i].LastName, rightArray[j].LastName) <= 0)
                {
                    employees[k] = leftArray[i];
                    i++;
                }
                else
                {
                    employees[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                employees[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                employees[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
