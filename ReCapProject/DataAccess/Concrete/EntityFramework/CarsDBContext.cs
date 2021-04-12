using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }

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
