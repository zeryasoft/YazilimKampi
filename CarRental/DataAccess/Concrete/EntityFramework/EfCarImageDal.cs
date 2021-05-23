using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarsDBContext>, ICarImageDal
    {
        public List<CarDetailDto> GetCarImageDetailsByCarIdDto(int carId)
        {
            using (CarsDBContext context = new CarsDBContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands on p.BrandId equals b.BrandId
                             join c in context.Colors on p.ColorId equals c.ColorId
                             join ci in context.CarImages on p.CarId equals ci.CarId
                             where p.CarId == carId
                             select new CarDetailDto
                             {
                                 CarId = p.CarId,
                                 CarName = p.Description,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 ModelYear = p.ModelYear,
                                 ImagePath = ci.ImagePath,
                                 Date = ci.Date
                             };
                return result.ToList();
            }
        }
    }
}
