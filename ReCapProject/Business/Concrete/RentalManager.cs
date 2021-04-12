using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentDal;

        public RentalManager(IRentalDal rentDal)
        {
            _rentDal = rentDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate==null);
            if (result.Count>0)
            {
                return new ErrorResult(Messages.RentalReturnDateInvalid);
            }
            _rentDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            _rentDal.GetAll();
            return new SuccessDataResult<List<Rental>>(Messages.RentalsListed);
        }

        public IDataResult<List<Rental>> GetRentalsByCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(p => p.CarId == id),Messages.RentalsListed);
        }

        public IDataResult<List<Rental>> GetRentalsByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(p => p.CustomerId == id), Messages.RentalsListed);
        }

        public IResult Update(Rental rental)
        {
            _rentDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
