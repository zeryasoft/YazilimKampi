using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,CarsDBContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarsDBContext context=new CarsDBContext())
            {
                var result=from r in context.Rentals
                           join c in context.Cars
                           on r.CarId equals c.CarId
                           join cm in context.Customers
                           on r.CustomerId equals cm.CustomerId
                           join b in context.Brands
                           on c.BrandId equals b.BrandId
                           join u in context.Users
                           on cm.UserId equals u.Id
                           select new RentalDetailDto
                           {
                               RentalId = r.RentalId,
                               BrandName = b.BrandName,
                               customerFirstAndLastName=u.FirstName+ " "+u.LastName,
                               rentDate=r.RentDate,
                               returnDate=r.ReturnDate
                            };
                return result.ToList();
            }
        }
    }
}
