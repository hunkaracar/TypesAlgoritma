using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryAlgoritma.Algoritmalar
{
    public class InsertionSort
    {
        public InsertionSort()
        {

        }

        public void InsertionSortByFirstName(Employee[] employees)
        {
            /*
             Her adımda bir anahtar (key) eleman seçilir ve sıralanmış bölümdeki elemanlarla karşılaştırılır. string.
            Compare fonksiyonu kullanılarak iki FirstName değeri karşılaştırılır ve gerektiğinde elemanlar kaydırılır. 
            */
            for (int i=1; i<employees.Length; i++)
            {
                Employee key = employees[i];
                int j = i - 1;

                while(j >= 0 && string.Compare(employees[j].FirstName, key.FirstName) > 0)
                {
                    employees[j + 1] = employees[j];
                    j = j - 1;
                }

                employees[j+1] = key;
            }

            foreach (var employee in employees)
            {
                //Genel Gösterir.
                Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName} -Salary: {employee.Salary}");

                //FirstName'e göre gösterir
                //Console.WriteLine($"{employee.FirstName}");
            }
        }
    }
}
