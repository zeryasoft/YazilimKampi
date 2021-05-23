using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarUpdateTest();
            //CarAddTest();
            //CarDeleteTest();
            //CarDetailTest();
            //UserAddTest();
            //CustomerAddTest();
            //RentalAddTest();
            //RentalUpdateTest();

            //ImageManager imageManager = new ImageManager(new EfImageDal());
            //imageManager.Add(new Image
            //{
            //    CarId = 1,
            //    Date = DateTime.Now,
            //    ImagePath = ""
            //});
            
            //gelAllColor();

        }

        private static void gelAllColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.ColorName);
            }
        }

        private static void RentalUpdateTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Update(new Rental { RentalId = 1, CarId = 1, CustomerId = 1, RentDate = DateTime.Now.ToShortDateString(), ReturnDate = DateTime.Now.ToShortDateString() });
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now.ToShortDateString() }).Message);
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerManager.Add(new Customer { UserId = 2, CompanyName = "Turkcell" }).Message);
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Id = 2, FirstName = "Enes", LastName = "KOÇ", Email = "enes@gmail.com" });

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car
            {
                CarId = 1004
            });
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 60000M,
                Description = "Temiz Araba",
                ModelYear = 2011
            });
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car
            {
                CarId = 1004,
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 65000M,
                Description = "Polo",
                ModelYear = 2011
            });
        }
    }
}
