using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.IEntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }


        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
            //using (TContext context = new TContext())
            //{
            //    context.Cars.Remove(context.Cars.SingleOrDefault(c => c.CarId == car.CarId));
            //    context.SaveChanges();
            //}
        }


        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }
        //public TEntity GetCarsByBrandId(int brandId)
        //{
        //    using (TContext context = new TContext())
        //    {
        //        return context.Cars.SingleOrDefault(c => c.BrandId == brandId);
        //    }
        //}

        public TEntity GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        //public TEntity GetCarsByColorId(int colorId)
        //{
        //    using (TContext context = new TContext())
        //    {
        //        return context.Cars.SingleOrDefault(c => c.ColorId == colorId);
        //    }
        //}

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
            //using (TContext context = new TContext())
            //{
            //    var carToUpdate = context.Cars.SingleOrDefault(c => c.CarId == car.CarId);
            //    carToUpdate.BrandId = car.BrandId;
            //    carToUpdate.ColorId = car.ColorId;
            //    carToUpdate.DailyPrice = car.DailyPrice;
            //    carToUpdate.Description = car.Description;
            //    carToUpdate.ModelYear = car.ModelYear;
            //    context.SaveChanges();
            //}
        }
    }
}
