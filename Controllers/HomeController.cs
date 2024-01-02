using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FutbolcuKartlariMVC.Models;
using FutbolcuKartlariMVC.Repositories;
using FutbolcuKartlariMVC.Context;

namespace FutbolcuKartlariMVC.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext db;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public HomeController(AppDbContext db)
    {
        this.db = db;
    }
    public IActionResult GetList()
    {
        return View(db.futbolcular.ToList());
    }
}
