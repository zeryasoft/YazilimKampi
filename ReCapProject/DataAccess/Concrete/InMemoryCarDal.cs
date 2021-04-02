using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal() => _cars = new List<Car>()
        {
          new Car()
          {
            BrandId = 1,
            CarId = 1,
            ColorId = 1,
            DailyPrice = 100000M,
            Description = "Temiz Araba",
            ModelYear = 2015
          },
          new Car()
          {
            BrandId = 1,
            CarId = 2,
            ColorId = 2,
            DailyPrice = 150000M,
            Description = "Az Kullanılmış Araba",
            ModelYear = 2019
          },
          new Car()
          {
            BrandId = 2,
            CarId = 3,
            ColorId = 3,
            DailyPrice = 155000M,
            Description = "Memurdan Araba",
            ModelYear = 2020
          },
          new Car()
          {
            BrandId = 2,
            CarId = 4,
            ColorId = 4,
            DailyPrice = 250000M,
            Description = "Sıfır Araba",
            ModelYear = 2021
          }
        };

        public void Add(Car car) => _cars.Add(car);

        public void Delete(Car car) => _cars.Remove(_cars.SingleOrDefault(p => p.CarId == car.CarId));

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int carId) => _cars.Where(p => p.CarId == carId).ToList();

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
