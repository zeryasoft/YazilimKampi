using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(),Messages.RentalsListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentDal.GetRentalDetails(), Messages.RentalsListed);
        }

        public IDataResult<List<Rental>> GetRentalsByUserId(int userId)
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(p => p.CarId == userId),Messages.RentalsListed);
        }

        public IDataResult<List<Rental>> GetRentalsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll(p => p.CustomerId == customerId), Messages.RentalsListed);
        }

        public IResult Update(Rental rental)
        {
            _rentDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentDal.Get(r => r.RentalId == rentalId));
        }
    }
}
