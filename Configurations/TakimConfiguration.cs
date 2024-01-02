using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutbolcuKartlariMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutbolcuKartlariMVC.Configurations
{
    public class TakimConfiguration : IEntityTypeConfiguration<Takim>
    {
        public void Configure(EntityTypeBuilder<Takim> builder)
        {
            builder.HasData(
        new Takim
        {
            ID = 1,
            TakimAdi = "Galatasaray"
        },
        new Takim
        {
            ID = 2,
            TakimAdi = "Besiktas"
        });
        }
    }
}