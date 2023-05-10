using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryAlgoritma
{
    public class dbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                //Database bağlandı
                string connectionString = "Data Source=C:\\Users\\Hunkar\\Desktop\\QueryAlgoritma\\QueryAlgoritma\\Employee.db";
                optionsBuilder.UseSqlite(connectionString);
            }
            catch (Microsoft.Data.Sqlite.SqliteException ex)
            {
                Console.WriteLine("Sqlite Hatası:" + ex.Message);
            }

            catch(Exception ex) 
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu:" + ex.Message);
            }
        }
    }
}
