using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        List<Car> _cars;
        public void Add(Car entity)
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }   
        }

        public void Delete(Car car)
        {
            using (CarsDBContext context=new CarsDBContext())
            {
                context.Cars.Remove(context.Cars.SingleOrDefault(c => c.CarId == car.CarId));
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car GetCarsByBrandId(int brandId)
        {
            using (CarsDBContext context=new CarsDBContext())
            {
                return context.Cars.SingleOrDefault(c => c.BrandId == brandId);
            }
        }

        public Car GetCarsByColorId(int colorId)
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                return context.Cars.SingleOrDefault(c => c.ColorId == colorId);
            }
        }

        public void Update(Car car)
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                var carToUpdate = context.Cars.SingleOrDefault(c => c.CarId == car.CarId);
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
                carToUpdate.ModelYear = car.ModelYear;
                context.SaveChanges();
            }
        }
    }
}
