using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutbolcuKartlariMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutbolcuKartlariMVC.Configurations
{
    public class UlkeConfiguration : IEntityTypeConfiguration<Ulke>
    {
        public void Configure(EntityTypeBuilder<Ulke> builder)
        {
            builder.HasData(
    new Ulke
    {
        ID = 1,
        UlkeAdi = "Uruguay"
    },
    new Ulke
    {
        ID = 2,
        UlkeAdi = "Belçika"
    },
    new Ulke
    {
        ID = 3,
        UlkeAdi = "Fildişi Sahili"
    },
    new Ulke
    {
        ID = 4,
        UlkeAdi = "Arjantin"
    },
    new Ulke
    {
        ID = 5,
        UlkeAdi = "Fas"
    },
    new Ulke
    {
        ID = 6,
        UlkeAdi = "Fransa"
    },
    new Ulke
    {
        ID = 7,
        UlkeAdi = "Almanya"
    },
    new Ulke
    {
        ID = 8,
        UlkeAdi = "İspanya"
    },
    new Ulke
    {
        ID = 9,
        UlkeAdi = "Danimarka"
    },
    new Ulke
    {
        ID = 10,
        UlkeAdi = "Portekiz"
    },
    new Ulke
    {
        ID = 11,
        UlkeAdi = "Türkiye"
    },
    new Ulke
    {
        ID = 12,
        UlkeAdi = "Kolombiya"
    },
    new Ulke
    {
        ID = 13,
        UlkeAdi = "Congo"
    },
    new Ulke
    {
        ID = 14,
        UlkeAdi = "Brezilya"
    },
    new Ulke
    {
        ID = 15,
        UlkeAdi = "Gana"
    },
    new Ulke
    {
        ID = 16,
        UlkeAdi = "Cezayir"
    },
    new Ulke
    {
        ID = 17,
        UlkeAdi = "İngiltere"
    },
    new Ulke
    {
        ID = 18,
        UlkeAdi = "Hırvatistan"
    },
    new Ulke
    {
        ID = 19,
        UlkeAdi = "Kosova"
    },
    new Ulke
    {
        ID = 20,
        UlkeAdi = "Bosna Hersek"
    },
    new Ulke
    {
        ID = 21,
        UlkeAdi = "Gambiya"
    },
    new Ulke
    {
        ID = 22,
        UlkeAdi = "Kamerun"
    }
     );
        }
    }
}