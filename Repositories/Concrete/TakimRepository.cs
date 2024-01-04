using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutbolcuKartlariMVC.Context;
using FutbolcuKartlariMVC.Entities;
using FutbolcuKartlariMVC.Repositories.Abstract;

namespace FutbolcuKartlariMVC.Repositories.Concrete;

public class TakimRepository : GenericRepository<Takim>, ITakimRepository
{
    private readonly AppDbContext dbContext;

    public TakimRepository(AppDbContext dbContext)
        : base(dbContext)
    {
        this.dbContext = dbContext;
    }
}
