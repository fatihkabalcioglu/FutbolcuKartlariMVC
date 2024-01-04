using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FutbolcuKartlariMVC.Entities;
using FutbolcuKartlariMVC.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FutbolcuKartlariMVC.Controllers;

public class TakimController : Controller
{
    private readonly ITakimRepository takimRepository;

    public TakimController(ITakimRepository takimRepository)
    {
        this.takimRepository = takimRepository;
    }
    public IActionResult GetList()
    {

        return View(takimRepository.GetAll().ToList());
    }
    public IActionResult Create( )
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Takim takim )
    {
        takimRepository.Add(takim);

        return RedirectToAction("GetList");
    }

    
    public IActionResult Update(int id)
    {
        

        return View(takimRepository.GetById(id));
    }
    [HttpPost]
    public IActionResult Update(Takim takim )
    {
        takimRepository.Update(takim);
        return RedirectToAction("GetList");
    }
    public IActionResult Delete(int id)
    {
        
        takimRepository.Delete(takimRepository.GetById(id));
        return RedirectToAction("GetList");
    }

    

}
