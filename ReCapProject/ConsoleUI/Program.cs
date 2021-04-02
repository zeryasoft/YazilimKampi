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
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.Description+ " "+car.ModelYear);
            //}

            carManager.Add(new Car {
                BrandId = 3,
                CarId = 3,
                ColorId = 1,
                DailyPrice = 100000M,
                Description = "Getz",
                ModelYear = 2015
            });
        }
    }
}
