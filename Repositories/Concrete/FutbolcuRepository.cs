using FutbolcuKartlariMVC.Context;
using FutbolcuKartlariMVC.Models.Entities;
using FutbolcuKartlariMVC.Repositories.Abstract;

namespace FutbolcuKartlariMVC.Repositories.Concrete
{
    public class FutbolcuRepository : GenericRepository<Futbolcu>, IFutbolcuRepository
    {
        private readonly AppDbContext dbContext;

        public FutbolcuRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
