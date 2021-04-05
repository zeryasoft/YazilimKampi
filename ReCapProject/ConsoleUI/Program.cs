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


            carManager.Update(new Car {
                CarId=6,
                BrandId = 3,
                ColorId = 1,
                DailyPrice = 10000M,
                Description = "Getz",
                ModelYear = 2011
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.ModelYear);
            }
        }
    }
}
