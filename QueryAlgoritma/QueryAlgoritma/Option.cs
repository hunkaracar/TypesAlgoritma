using Microsoft.EntityFrameworkCore;
using QueryAlgoritma.Algoritmalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryAlgoritma
{


    public class Option : BubbleSort
    {

        public Option()
        {

        }

        public void Choose_opt()
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("\n0.Veri tabanınındaki değerleri göster: ");
                Console.WriteLine("1.Bubble Sort Salary'e göre: ");
                Console.WriteLine("2.Insertion Sort Firstname'e göre: ");
                Console.WriteLine("3.Merge Sort LastName'e göre: ");
                Console.WriteLine("4.Quick Sort Salary'e göre: ");
                Console.WriteLine("5.Programdan Çıkış Yap");


                Console.WriteLine("\nSeçenek Seçin => ");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 0:

                        using (var dbcontext = new dbContext())
                        {
                            var employees = dbcontext.Employees.ToList();

                            //VeriTabanındaki değerleri çeker ve Console'da görüntüleriz.
                            foreach (var employee in employees)
                            {
                                Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName} -Salary: {employee.Salary}  -Title {employee.Title}");
                            }
                        }
                        break;

                    case 1:

                        Console.WriteLine("\nBubble Sort Salary Alanına göre Sıralama:");

                        using (var dbcontext = new dbContext())
                        {
                            var employees = dbcontext.Employees.ToArray();

                            var bubblesort = new BubbleSort();
                            bubblesort.BubbleSortBySalary(employees);
                        }
                        break;

                    case 2:

                        Console.WriteLine("\nInsertion Sort FirstName alanına göre Sıralama:");

                        try
                        {
                            using (var dbcontext = new dbContext())
                            {
                                var employees = dbcontext.Employees.ToArray();
                                var insertions = new InsertionSort();
                                insertions.InsertionSortByFirstName(employees);
                            }
                        }
                        catch (System.IndexOutOfRangeException ex)
                        {
                            Console.WriteLine("İndex Hatası" + ex.Message);
                        }
                        break;

                    case 3:

                        Console.WriteLine("\nMerge Sort LastName alanına göre Sıralama:");
                        using (var dbcontext = new dbContext())
                        {
                            var employees = dbcontext.Employees.ToArray();
                            var mergesort = new MergeSort();
                            mergesort.MergeSortByLastName(employees);
                        }
                        break;

                    case 4:

                        Console.WriteLine("\nQuick Sort Salary Alanına göre Sıralama:");

                        using (var dbcontext = new dbContext())
                        {
                            var employees = dbcontext.Employees.ToArray();
                            var quicksort = new QuickSort();
                            quicksort.QuickSortBySalary(employees);
                        }
                        break;

                    default:
                        loop = false;
                        break;
                }
                
            }


        }
    }
}