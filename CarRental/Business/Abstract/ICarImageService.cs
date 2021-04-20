using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> Get(int Id);
        IDataResult<List<CarImage>> GetImagesByCarId(int carId);
        IDataResult<List<CarImage>> GetById(int carId);

        IResult Add(IFormFile file, CarImage image);
        IResult Update(IFormFile file, CarImage image);
        IResult Delete(CarImage image);
    }
}
