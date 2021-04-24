using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);

        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

        IDataResult<List<UserDetailDto>> GetUserDetails();
    }
}
