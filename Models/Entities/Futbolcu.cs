using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutbolcuKartlariMVC.Models.Enums;

namespace FutbolcuKartlariMVC.Models.Entities
{
    public class Futbolcu
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public int Yas { get; set; }
        public Takim Takim { get; set; }
        public Mevki Mevki { get; set; }
        public Ulke Ulke { get; set; }
        public byte Pas { get; set; }
        public byte Dribbling { get; set; }
        public byte Sut { get; set; }
        public byte Defans { get; set; }
        public byte Fizik { get; set; }
        public byte Hiz { get; set; }
        public decimal Degeri { get; set; }
        public Ayak Ayak { get; set; }
        public int OrtalamaDeger { get; set; }
        public int TakimID { get; set; }
        public int MevkiID { get; set; }
        public int UlkeID { get; set; }
    }
}