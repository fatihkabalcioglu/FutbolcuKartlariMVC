using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutbolcuKartlariMVC.Models.Entities;

namespace FutbolcuKartlariMVC.Entities
{
    public class Takim : BaseEntity
    {
        public int ID { get; set; }
        public string? TakimAdi { get; set; }
        public ICollection<Futbolcu>? Futbolcular { get; set; }
    }
}