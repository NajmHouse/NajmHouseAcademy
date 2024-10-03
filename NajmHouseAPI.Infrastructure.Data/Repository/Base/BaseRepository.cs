using Microsoft.EntityFrameworkCore;
using NajmHouseAPI.Domian.Entity;
using NajmHouseAPI.Domian.Interface.Base;
using NajmHouseAPI.Infrastructure.Data.Models;

namespace NajmHouseAPI.Infrastructure.Data.Repository.Base
{

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        /*
            This is where we communicate with database,
            and it stands for all the classes.              
         */
        private readonly NajmHouseContext _dbContext;
        public BaseRepository(NajmHouseContext dbContext)
        {
            _dbContext = dbContext;
        }
        //public T Add(T entity)
        //{
        //    _dbContext.Set<T>().Add(entity);
        //    return entity;
        //}

        //public void Delete(T entity)
        //{
        //    _dbContext.Set<T>().Remove(entity);
        //}

       

        public IReadOnlyList<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        //        public T GetById(Guid id)
        //        {
        //            return _dbContext.Set<T>().Find(id)
        //;
        //        }

        //        public void Update(T entity)
        //        {
        //            _dbContext.Entry(entity).State = EntityState.Modified;
        //        }

        //        public void SaveChanges()
        //        {
        //            _dbContext.SaveChanges();
        //        }
    }

}
