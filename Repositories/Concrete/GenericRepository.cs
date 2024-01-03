using FutbolcuKartlariMVC.Context;
using FutbolcuKartlariMVC.Models.Entities;
using FutbolcuKartlariMVC.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace FutbolcuKartlariMVC.Repositories.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext dbContext;

        public GenericRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public bool Add(T entity)
        {
            try
            {
                dbContext.Set<T>().Add(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                dbContext.Set<T>().Remove(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
            try
            {
                dbContext.Set<T>().Update(entity);
                return dbContext.SaveChanges() > 0;
            }
            catch
            {

                return false;
            }
        }
    }
}
