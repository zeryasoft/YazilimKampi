using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal :EfEntityRepositoryBase<Car,CarsDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice=c.DailyPrice,
                                 ModelYear=c.ModelYear
                                 
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             join c in context.Colors
                             on p.ColorId equals c.ColorId
                             where p.BrandId == brandId
                             select new CarDetailDto
                             {
                                 CarId = p.CarId,
                                 CarName = p.Description,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 ModelYear = p.ModelYear
                                 
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByCarId(int carId)
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands on p.BrandId equals b.BrandId
                             join c in context.Colors on p.ColorId equals c.ColorId
                             where p.CarId == carId
                             select new CarDetailDto
                             {
                                 CarId = p.CarId,
                                 CarName = p.Description,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 ModelYear = p.ModelYear
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             join c in context.Colors
                             on p.ColorId equals c.ColorId
                             where p.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = p.CarId,
                                 CarName = p.Description,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 ModelYear = p.ModelYear

                             };
                return result.ToList();
            }
        }
    }
}
