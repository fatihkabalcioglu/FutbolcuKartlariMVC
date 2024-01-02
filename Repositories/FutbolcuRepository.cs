using FutbolcuKartlariMVC.Context;
using FutbolcuKartlariMVC.Models.Entities;

namespace FutbolcuKartlariMVC.Repositories
{
    public class FutbolcuRepository
    {
        public readonly AppDbContext dbContext;
        public FutbolcuRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Futbolcu> GetFootballPlayers()
        {
            List<Futbolcu> futbolcular = dbContext.futbolcular.ToList();
            return futbolcular;
        }
    }
}
