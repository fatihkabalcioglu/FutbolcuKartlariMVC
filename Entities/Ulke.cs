using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbolcuKartlariMVC.Entities
{
    public class Ulke
    {
        public int ID { get; set; }
        public string? UlkeAdi { get; set; }
        public ICollection<Futbolcu>? Futbolcular { get; set; }
    }
}