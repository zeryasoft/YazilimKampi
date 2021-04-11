using Business.Concrete;
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
            GetCarsByBrandIdAndColorID();

        }

        private static void GetCarsByBrandIdAndColorID()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("By BrandId\n"+carManager.GetCarsByBrandId(2).Data.Description);
            Console.WriteLine("By ColorId");
            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.Description);
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
