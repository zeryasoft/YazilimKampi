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
                var result = from p in context.Cars
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             join c in context.Colors
                             on p.ColorId equals c.ColorId
                             select new CarDetailDto
                             {
                                 CarId = p.CarId,
                                 CarName = p.Description,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice=p.DailyPrice
                             };
                return result.ToList();
            }
        }

    }
}
