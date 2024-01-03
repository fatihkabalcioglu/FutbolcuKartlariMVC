using FutbolcuKartlariMVC.Models.Entities;

namespace FutbolcuKartlariMVC.Repositories.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
