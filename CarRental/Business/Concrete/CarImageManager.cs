using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _imageDal;

        public CarImageManager(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage image)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageCountCorrect(image.CarId));
            if (result == null)
            {
                return result;
            }

            image.ImagePath = FileHelper.Upload(file).ToString();
            _imageDal.Add(image);           
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult CheckIfCarImageCountCorrect(int carId)
        {
            var result = _imageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 5)
            {
                return new ErrorResult(Messages.ImageLimitExceeded);
            }
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage image)
        {
            var isImage = _imageDal.Get(c => c.ImageId == image.ImageId);
            if (isImage == null)
            {
                return new ErrorResult(Messages.ImageNotFound);
            }

            var updatedFile = FileHelper.Update(file, isImage.ImagePath);
            if (!updatedFile.Success)
            {
                return new ErrorResult(updatedFile.Message);
            }
            image.ImagePath = updatedFile.Message;
            _imageDal.Update(image);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(CarImage image)
        {
            var result = _imageDal.Get(c => c.ImageId == image.ImageId);
            if (result == null)
            {
                return new ErrorResult(Messages.ImageNotFound);
            }

            FileHelper.Delete(result.ImagePath);
            _imageDal.Delete(result);
            return new SuccessResult(Messages.ImageDeleted);
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<CarImage> Get(int Id)
        {
            return new SuccessDataResult<CarImage>(_imageDal.Get(p=>p.CarId==Id));
        }

        public IDataResult<List<CarImage>> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageNull(carId));
            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(result.Message);
            }
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(carId).Data);
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll(),Messages.ImagesListed);
        }

        private IDataResult<List<CarImage>> CheckIfCarImageNull(int carId)
        {
            try
            {
                string path = @"\images\logo.jpg";
                var result = _imageDal.GetAll(c => c.CarId == carId).Any();
                if (!result)
                {
                    List<CarImage> image = new List<CarImage>();
                    image.Add(new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now });
                    return new SuccessDataResult<List<CarImage>>(image);
                }
            }
            catch (Exception exception)
            {
                return new ErrorDataResult<List<CarImage>>(exception.Message);
            }
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll(p => p.CarId == carId).ToList());
        }

        private IResult CheckImageLimitExceeded(int carid)
        {
            var imagecount = _imageDal.GetAll(p => p.CarId == carid).Count;
            if (imagecount >= 5)
            {
                return new ErrorResult(Messages.ImageLimitExceeded);
            }

            return new SuccessResult();
        }

        private IResult ImageDelete(CarImage image)
        {
            try
            {
                File.Delete(image.ImagePath);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }


    }
}
