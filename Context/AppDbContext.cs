using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutbolcuKartlariMVC.Configurations;
using FutbolcuKartlariMVC.Models.Entities;
using FutbolcuKartlariMVC.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace FutbolcuKartlariMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Futbolcu>().HasData(
                new Futbolcu
                {
                    ID = 1,
                    Ad = "Lucas",
                    Soyad = "Torreira",
                    Mevki = Mevki.Ortasaha,
                    Yas = 27,
                    Boy = 166,
                    Kilo = 60,
                    Ayak = Ayak.Sağ,
                    Degeri = 15000000,
                    OrtalamaDeger = 82,
                    Defans = 79,
                    Dribbling = 80,
                    Fizik = 78,
                    Hiz = 76,
                    Pas = 77,
                    Sut = 70,
                    TakimID = 1,
                    UlkeID = 1
                },
                new Futbolcu
                {
                    ID = 2,
                    Ad = "Dries",
                    Soyad = "Mertens",
                    Mevki = Mevki.Forvet,
                    Yas = 36,
                    Boy = 169,
                    Kilo = 61,
                    Ayak = Ayak.Sağ,
                    Degeri = 2600000,
                    OrtalamaDeger = 81,
                    Defans = 40,
                    Dribbling = 83,
                    Fizik = 49,
                    Hiz = 76,
                    Pas = 80,
                    Sut = 80,
                    TakimID = 1,
                    UlkeID = 2
                },
                new Futbolcu
                {
                    ID = 3,
                    Ad = "Wilfried",
                    Soyad = "Zaha",
                    Mevki = Mevki.Forvet,
                    Yas = 31,
                    Boy = 180,
                    Kilo = 66,
                    Ayak = Ayak.Sağ,
                    Degeri = 20000000,
                    OrtalamaDeger = 81,
                    Defans = 37,
                    Dribbling = 85,
                    Fizik = 76,
                    Hiz = 90,
                    Pas = 72,
                    Sut = 78,
                    TakimID = 1,
                    UlkeID = 3
                },
                new Futbolcu
                {
                    ID = 4,
                    Ad = "Mauro",
                    Soyad = "Icardi",
                    Mevki = Mevki.Forvet,
                    Yas = 30,
                    Boy = 181,
                    Kilo = 75,
                    Ayak = Ayak.Sağ,
                    Degeri = 20000000,
                    OrtalamaDeger = 80,
                    Defans = 40,
                    Dribbling = 73,
                    Fizik = 72,
                    Hiz = 67,
                    Pas = 69,
                    Sut = 81,
                    TakimID = 1,
                    UlkeID = 4
                },
                new Futbolcu
                {
                    ID = 5,
                    Ad = "Fernando",
                    Soyad = "Muslera",
                    Mevki = Mevki.Kaleci,
                    Yas = 37,
                    Boy = 190,
                    Kilo = 74,
                    Ayak = Ayak.Sağ,
                    Degeri = 1500000,
                    OrtalamaDeger = 80,
                    Defans = 51,
                    Dribbling = 77,
                    Fizik = 83,
                    Hiz = 76,
                    Pas = 72,
                    Sut = 80,
                    TakimID = 1,
                    UlkeID = 1
                },
                new Futbolcu
                {
                    ID = 6,
                    Ad = "Hakim",
                    Soyad = "Ziyech",
                    Mevki = Mevki.Forvet,
                    Yas = 30,
                    Boy = 181,
                    Kilo = 65,
                    Ayak = Ayak.Sol,
                    Degeri = 15000000,
                    OrtalamaDeger = 80,
                    Defans = 50,
                    Dribbling = 81,
                    Fizik = 64,
                    Hiz = 74,
                    Pas = 83,
                    Sut = 75,
                    TakimID = 1,
                    UlkeID = 5
                },
                new Futbolcu
                {
                    ID = 7,
                    Ad = "Sacha",
                    Soyad = "Boey",
                    Mevki = Mevki.Defans,
                    Yas = 23,
                    Boy = 178,
                    Kilo = 70,
                    Ayak = Ayak.Sağ,
                    Degeri = 17000000,
                    OrtalamaDeger = 79,
                    Defans = 76,
                    Dribbling = 75,
                    Fizik = 84,
                    Hiz = 86,
                    Pas = 65,
                    Sut = 55,
                    TakimID = 1,
                    UlkeID = 6
                },
                new Futbolcu
                {
                    ID = 8,
                    Ad = "Kerem",
                    Soyad = "Demirbay",
                    Mevki = Mevki.Ortasaha,
                    Yas = 30,
                    Boy = 183,
                    Kilo = 75,
                    Ayak = Ayak.Sol,
                    Degeri = 6000000,
                    OrtalamaDeger = 79,
                    Defans = 71,
                    Dribbling = 81,
                    Fizik = 71,
                    Hiz = 59,
                    Pas = 79,
                    Sut = 76,
                    TakimID = 1,
                    UlkeID = 7
                },
                new Futbolcu
                {
                    ID = 9,
                    Ad = "Angelino",
                    Soyad = "Tasende",
                    Mevki = Mevki.Defans,
                    Yas = 26,
                    Boy = 171,
                    Kilo = 69,
                    Ayak = Ayak.Sol,
                    Degeri = 11000000,
                    OrtalamaDeger = 79,
                    Defans = 74,
                    Dribbling = 82,
                    Fizik = 68,
                    Hiz = 71,
                    Pas = 81,
                    Sut = 71,
                    TakimID = 1,
                    UlkeID = 8
                },
                new Futbolcu
                {
                    ID = 10,
                    Ad = "Tanguy",
                    Soyad = "Ndombele",
                    Mevki = Mevki.Ortasaha,
                    Yas = 26,
                    Boy = 181,
                    Kilo = 76,
                    Ayak = Ayak.Sağ,
                    Degeri = 21000000,
                    OrtalamaDeger = 78,
                    Defans = 68,
                    Dribbling = 86,
                    Fizik = 66,
                    Hiz = 65,
                    Pas = 79,
                    Sut = 71,
                    TakimID = 1,
                    UlkeID = 6
                },
                new Futbolcu
                {
                    ID = 11,
                    Ad = "Victor",
                    Soyad = "Nelsson",
                    Mevki = Mevki.Defans,
                    Yas = 25,
                    Boy = 185,
                    Kilo = 78,
                    Ayak = Ayak.Sağ,
                    Degeri = 19000000,
                    OrtalamaDeger = 78,
                    Defans = 79,
                    Dribbling = 66,
                    Fizik = 84,
                    Hiz = 64,
                    Pas = 59,
                    Sut = 43,
                    TakimID = 1,
                    UlkeID = 9
                },
                new Futbolcu
                {
                    ID = 12,
                    Ad = "Sergio",
                    Soyad = "Oliveira",
                    Mevki = Mevki.Ortasaha,
                    Yas = 31,
                    Boy = 181,
                    Kilo = 78,
                    Ayak = Ayak.Sağ,
                    Degeri = 6000000,
                    OrtalamaDeger = 78,
                    Defans = 67,
                    Dribbling = 74,
                    Fizik = 62,
                    Hiz = 51,
                    Pas = 82,
                    Sut = 76,
                    TakimID = 1,
                    UlkeID = 10
                },
                new Futbolcu
                {
                    ID = 13,
                    Ad = "Kerem",
                    Soyad = "Aktürkoğlu",
                    Mevki = Mevki.Forvet,
                    Yas = 25,
                    Boy = 173,
                    Kilo = 71,
                    Ayak = Ayak.Sağ,
                    Degeri = 17000000,
                    OrtalamaDeger = 77,
                    Defans = 38,
                    Dribbling = 79,
                    Fizik = 56,
                    Hiz = 84,
                    Pas = 71,
                    Sut = 73,
                    TakimID = 1,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 14,
                    Ad = "Abdulkerim",
                    Soyad = "Bardakçı",
                    Mevki = Mevki.Defans,
                    Yas = 29,
                    Boy = 190,
                    Kilo = 80,
                    Ayak = Ayak.Sol,
                    Degeri = 7500000,
                    OrtalamaDeger = 77,
                    Defans = 78,
                    Dribbling = 65,
                    Fizik = 83,
                    Hiz = 61,
                    Pas = 64,
                    Sut = 32,
                    TakimID = 1,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 15,
                    Ad = "Davinson",
                    Soyad = "Sanchez",
                    Mevki = Mevki.Defans,
                    Yas = 27,
                    Boy = 187,
                    Kilo = 81,
                    Ayak = Ayak.Sağ,
                    Degeri = 14000000,
                    OrtalamaDeger = 77,
                    Defans = 77,
                    Dribbling = 64,
                    Fizik = 78,
                    Hiz = 73,
                    Pas = 54,
                    Sut = 47,
                    TakimID = 1,
                    UlkeID = 12
                },
                new Futbolcu
                {
                    ID = 16,
                    Ad = "Cedric",
                    Soyad = "Bakambu",
                    Mevki = Mevki.Forvet,
                    Yas = 32,
                    Boy = 182,
                    Kilo = 73,
                    Ayak = Ayak.Sağ,
                    Degeri = 3400000,
                    OrtalamaDeger = 76,
                    Defans = 36,
                    Dribbling = 73,
                    Fizik = 63,
                    Hiz = 81,
                    Pas = 66,
                    Sut = 77,
                    TakimID = 1,
                    UlkeID = 13
                },
                new Futbolcu
                {
                    ID = 17,
                    Ad = "Mateus",
                    Soyad = "Tete",
                    Mevki = Mevki.Forvet,
                    Yas = 23,
                    Boy = 175,
                    Kilo = 70,
                    Ayak = Ayak.Sol,
                    Degeri = 24000000,
                    OrtalamaDeger = 76,
                    Defans = 41,
                    Dribbling = 79,
                    Fizik = 55,
                    Hiz = 81,
                    Pas = 72,
                    Sut = 72,
                    TakimID = 1,
                    UlkeID = 14
                },
                new Futbolcu
                {
                    ID = 18,
                    Ad = "Günay",
                    Soyad = "Güvenç",
                    Mevki = Mevki.Kaleci,
                    Yas = 32,
                    Boy = 187,
                    Kilo = 85,
                    Ayak = Ayak.Sağ,
                    Degeri = 1500000,
                    OrtalamaDeger = 74,
                    Defans = 55,
                    Dribbling = 76,
                    Fizik = 71,
                    Hiz = 73,
                    Pas = 72,
                    Sut = 72,
                    TakimID = 1,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 19,
                    Ad = "Kaan",
                    Soyad = "Ayhan",
                    Mevki = Mevki.Defans,
                    Yas = 29,
                    Boy = 184,
                    Kilo = 84,
                    Ayak = Ayak.Sağ,
                    Degeri = 3700000,
                    OrtalamaDeger = 72,
                    Defans = 72,
                    Dribbling = 67,
                    Fizik = 74,
                    Hiz = 58,
                    Pas = 69,
                    Sut = 53,
                    TakimID = 1,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 20,
                    Ad = "Barış Alper",
                    Soyad = "Yılmaz",
                    Mevki = Mevki.Forvet,
                    Yas = 23,
                    Boy = 186,
                    Kilo = 72,
                    Ayak = Ayak.Sağ,
                    Degeri = 5500000,
                    OrtalamaDeger = 72,
                    Defans = 37,
                    Dribbling = 71,
                    Fizik = 84,
                    Hiz = 87,
                    Pas = 64,
                    Sut = 70,
                    TakimID = 1,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 21,
                    Ad = "Mert",
                    Soyad = "Günok",
                    Mevki = Mevki.Kaleci,
                    Yas = 34,
                    Boy = 196,
                    Kilo = 92,
                    Ayak = Ayak.Sağ,
                    Degeri = 1500000,
                    OrtalamaDeger = 75,
                    Defans = 17,
                    Dribbling = 73,
                    Fizik = 53,
                    Hiz = 56,
                    Pas = 35,
                    Sut = 22,
                    TakimID = 2,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 22,
                    Ad = "Daniel",
                    Soyad = "Amartey",
                    Mevki = Mevki.Defans,
                    Yas = 28,
                    Boy = 186,
                    Kilo = 79,
                    Ayak = Ayak.Sağ,
                    Degeri = 12000000,
                    OrtalamaDeger = 83,
                    Defans = 84,
                    Dribbling = 77,
                    Fizik = 82,
                    Hiz = 78,
                    Pas = 71,
                    Sut = 64,
                    TakimID = 2,
                    UlkeID = 15
                },
                new Futbolcu
                {
                    ID = 23,
                    Ad = "Eric",
                    Soyad = "Bailly",
                    Mevki = Mevki.Defans,
                    Yas = 29,
                    Boy = 187,
                    Kilo = 77,
                    Ayak = Ayak.Sağ,
                    Degeri = 4000000,
                    OrtalamaDeger = 85,
                    Defans = 85,
                    Dribbling = 73,
                    Fizik = 85,
                    Hiz = 81,
                    Pas = 70,
                    Sut = 51,
                    TakimID = 2,
                    UlkeID = 3
                },
                new Futbolcu
                {
                    ID = 24,
                    Ad = "Rachid",
                    Soyad = "Ghezzal",
                    Mevki = Mevki.Forvet,
                    Yas = 31,
                    Boy = 182,
                    Kilo = 70,
                    Ayak = Ayak.Sol,
                    Degeri = 4000000,
                    OrtalamaDeger = 78,
                    Defans = 28,
                    Dribbling = 81,
                    Fizik = 58,
                    Hiz = 71,
                    Pas = 81,
                    Sut = 72,
                    TakimID = 2,
                    UlkeID = 16
                },
                new Futbolcu
                {
                    ID = 25,
                    Ad = "Necip",
                    Soyad = "Uysal",
                    Mevki = Mevki.Defans,
                    Yas = 32,
                    Boy = 180,
                    Kilo = 72,
                    Ayak = Ayak.Sağ,
                    Degeri = 600000,
                    OrtalamaDeger = 68,
                    Defans = 68,
                    Dribbling = 63,
                    Fizik = 72,
                    Hiz = 54,
                    Pas = 61,
                    Sut = 56,
                    TakimID = 2,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 26,
                    Ad = "Gedson",
                    Soyad = "Fernandes",
                    Mevki = Mevki.Ortasaha,
                    Yas = 24,
                    Boy = 183,
                    Kilo = 63,
                    Ayak = Ayak.Sağ,
                    Degeri = 17000000,
                    OrtalamaDeger = 78,
                    Defans = 75,
                    Dribbling = 80,
                    Fizik = 77,
                    Hiz = 79,
                    Pas = 76,
                    Sut = 73,
                    TakimID = 2,
                    UlkeID = 10
                },
                new Futbolcu
                {
                    ID = 27,
                    Ad = "Alex Oxlade",
                    Soyad = "Chamberlain",
                    Mevki = Mevki.Ortasaha,
                    Yas = 30,
                    Boy = 175,
                    Kilo = 70,
                    Ayak = Ayak.Sağ,
                    Degeri = 6000000,
                    OrtalamaDeger = 77,
                    Defans = 67,
                    Dribbling = 81,
                    Fizik = 72,
                    Hiz = 78,
                    Pas = 76,
                    Sut = 74,
                    TakimID = 2,
                    UlkeID = 17
                },
                new Futbolcu
                {
                    ID = 28,
                    Ad = "Ante",
                    Soyad = "Rebic",
                    Mevki = Mevki.Forvet,
                    Yas = 30,
                    Boy = 185,
                    Kilo = 80,
                    Ayak = Ayak.Sağ,
                    Degeri = 5000000,
                    OrtalamaDeger = 77,
                    Defans = 46,
                    Dribbling = 77,
                    Fizik = 77,
                    Hiz = 80,
                    Pas = 72,
                    Sut = 77,
                    TakimID = 2,
                    UlkeID = 18
                },
                new Futbolcu
                {
                    ID = 29,
                    Ad = "Milot",
                    Soyad = "Rashica",
                    Mevki = Mevki.Ortasaha,
                    Yas = 27,
                    Boy = 277,
                    Kilo = 73,
                    Ayak = Ayak.Sağ,
                    Degeri = 8500000,
                    OrtalamaDeger = 76,
                    Defans = 50,
                    Dribbling = 77,
                    Fizik = 73,
                    Hiz = 81,
                    Pas = 71,
                    Sut = 75,
                    TakimID = 2,
                    UlkeID = 19
                },
                new Futbolcu
                {
                    ID = 30,
                    Ad = "Arthur",
                    Soyad = "Masuaku",
                    Mevki = Mevki.Defans,
                    Yas = 30,
                    Boy = 179,
                    Kilo = 80,
                    Ayak = Ayak.Sol,
                    Degeri = 6000000,
                    OrtalamaDeger = 76,
                    Defans = 70,
                    Dribbling = 79,
                    Fizik = 79,
                    Hiz = 79,
                    Pas = 73,
                    Sut = 61,
                    TakimID = 2,
                    UlkeID = 13
                },
                new Futbolcu
                {
                    ID = 31,
                    Ad = "Valentin",
                    Soyad = "Roiser",
                    Mevki = Mevki.Defans,
                    Yas = 27,
                    Boy = 175,
                    Kilo = 75,
                    Ayak = Ayak.Sağ,
                    Degeri = 6000000,
                    OrtalamaDeger = 76,
                    Defans = 72,
                    Dribbling = 75,
                    Fizik = 76,
                    Hiz = 84,
                    Pas = 65,
                    Sut = 52,
                    TakimID = 2,
                    UlkeID = 6
                },
                new Futbolcu
                {
                    ID = 32,
                    Ad = "Amir",
                    Soyad = "Hadziahmetovic",
                    Mevki = Mevki.Ortasaha,
                    Yas = 26,
                    Boy = 179,
                    Kilo = 70,
                    Ayak = Ayak.Sağ,
                    Degeri = 8000000,
                    OrtalamaDeger = 75,
                    Defans = 71,
                    Dribbling = 72,
                    Fizik = 77,
                    Hiz = 71,
                    Pas = 71,
                    Sut = 60,
                    TakimID = 2,
                    UlkeID = 20
                },
                new Futbolcu
                {
                    ID = 33,
                    Ad = "Cenk",
                    Soyad = "Tosun",
                    Mevki = Mevki.Forvet,
                    Yas = 32,
                    Boy = 183,
                    Kilo = 78,
                    Ayak = Ayak.Sağ,
                    Degeri = 3000000,
                    OrtalamaDeger = 75,
                    Defans = 36,
                    Dribbling = 72,
                    Fizik = 72,
                    Hiz = 66,
                    Pas = 67,
                    Sut = 77,
                    TakimID = 2,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 34,
                    Ad = "Omar",
                    Soyad = "Collay",
                    Mevki = Mevki.Defans,
                    Yas = 31,
                    Boy = 191,
                    Kilo = 90,
                    Ayak = Ayak.Sol,
                    Degeri = 3800000,
                    OrtalamaDeger = 74,
                    Defans = 73,
                    Dribbling = 55,
                    Fizik = 84,
                    Hiz = 64,
                    Pas = 48,
                    Sut = 31,
                    TakimID = 2,
                    UlkeID = 21
                },
                new Futbolcu
                {
                    ID = 35,
                    Ad = "Jean",
                    Soyad = "Onana",
                    Mevki = Mevki.Ortasaha,
                    Yas = 23,
                    Boy = 189,
                    Kilo = 85,
                    Ayak = Ayak.Sağ,
                    Degeri = 4800000,
                    OrtalamaDeger = 74,
                    Defans = 71,
                    Dribbling = 71,
                    Fizik = 82,
                    Hiz = 54,
                    Pas = 70,
                    Sut = 66,
                    TakimID = 2,
                    UlkeID = 22
                },
                new Futbolcu
                {
                    ID = 36,
                    Ad = "Salih",
                    Soyad = "Ucan",
                    Mevki = Mevki.Ortasaha,
                    Yas = 29,
                    Boy = 182,
                    Kilo = 80,
                    Ayak = Ayak.Sağ,
                    Degeri = 5000000,
                    OrtalamaDeger = 74,
                    Defans = 66,
                    Dribbling = 75,
                    Fizik = 65,
                    Hiz = 57,
                    Pas = 75,
                    Sut = 70,
                    TakimID = 2,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 37,
                    Ad = "Ersin",
                    Soyad = "Destanoglu",
                    Mevki = Mevki.Kaleci,
                    Yas = 22,
                    Boy = 195,
                    Kilo = 88,
                    Ayak = Ayak.Sağ,
                    Degeri = 3500000,
                    OrtalamaDeger = 74,
                    Defans = 11,
                    Dribbling = 32,
                    Fizik = 40,
                    Hiz = 38,
                    Pas = 20,
                    Sut = 16,
                    TakimID = 2,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 38,
                    Ad = "Onur",
                    Soyad = "Bulut",
                    Mevki = Mevki.Ortasaha,
                    Yas = 29,
                    Boy = 179,
                    Kilo = 80,
                    Ayak = Ayak.Sağ,
                    Degeri = 3800000,
                    OrtalamaDeger = 70,
                    Defans = 64,
                    Dribbling = 70,
                    Fizik = 72,
                    Hiz = 77,
                    Pas = 69,
                    Sut = 59,
                    TakimID = 2,
                    UlkeID = 11
                },
                new Futbolcu
                {
                    ID = 39,
                    Ad = "Jackson",
                    Soyad = "Muleko",
                    Mevki = Mevki.Forvet,
                    Yas = 24,
                    Boy = 180,
                    Kilo = 80,
                    Ayak = Ayak.Sağ,
                    Degeri = 4500000,
                    OrtalamaDeger = 70,
                    Defans = 35,
                    Dribbling = 71,
                    Fizik = 71,
                    Hiz = 81,
                    Pas = 58,
                    Sut = 71,
                    TakimID = 2,
                    UlkeID = 13
                },
                new Futbolcu
                {
                    ID = 40,
                    Ad = "Umut",
                    Soyad = "Meras",
                    Mevki = Mevki.Defans,
                    Yas = 27,
                    Boy = 178,
                    Kilo = 73,
                    Ayak = Ayak.Sol,
                    Degeri = 4500000,
                    OrtalamaDeger = 67,
                    Defans = 62,
                    Dribbling = 65,
                    Fizik = 70,
                    Hiz = 74,
                    Pas = 59,
                    Sut = 42,
                    TakimID = 2,
                    UlkeID = 11
                }
            );


            modelBuilder.Entity<Takim>().HasData(
                new Takim
                {
                    ID = 1,
                    TakimAdi = "Galatasaray"
                },
                new Takim
                {
                    ID = 2,
                    TakimAdi = "Besiktas"
                }
                    );


            modelBuilder.Entity<Ulke>().HasData(
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

            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Futbolcu> futbolcular { get; set; }
        public DbSet<Takim> takimlar { get; set; }
        public DbSet<Ulke> ulkeler { get; set; }
    }
}