﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    class EfBrandDal : IBrandDal
    {
        public void Add(Brand car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand car)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand car)
        {
            throw new NotImplementedException();
        }
    }
}
