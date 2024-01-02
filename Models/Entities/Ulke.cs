using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbolcuKartlariMVC.Models.Entities
{
    public class Ulke
    {
        public int ID { get; set; }
        public string? UlkeAdi { get; set; }
        public ICollection<Futbolcu>? Futbolcular { get; set; }
    }
}