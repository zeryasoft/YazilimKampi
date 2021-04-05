using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarsDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CarsDB; Integrated Security=True");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            //modelBuilder.HasDefaultSchema("dbo");//ornek şema
            modelBuilder.Entity<OrnekPersonel>().ToTable("Employees");
            //OrnekPersonel adlı nesneyi veritabanındaki Employees'a dönüştürür
            //Aşağıdaki satırlar ise Kolun adlarını eşleştiriyor
            modelBuilder.Entity<OrnekPersonel>().Property("PersonelId").HasColumnName("EmployeeID");
            modelBuilder.Entity<OrnekPersonel>().Property("PersonelAdi").HasColumnName("FirstName");
            modelBuilder.Entity<OrnekPersonel>().Property("PersonelSoyadi").HasColumnName("LastName");

            */
        }
    }
}
