using FutbolcuKartlariMVC.Models.Entities;
using FutbolcuKartlariMVC.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FutbolcuKartlariMVC.Controllers
{
    public class FutbolcuController : Controller
    {
        private readonly Repositories.Abstract.IFutbolcuRepository repository;

        public FutbolcuController(IFutbolcuRepository repository) 
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            List<Futbolcu> futbolcu = repository.GetAll().ToList();
            return View(futbolcu);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Futbolcu futbolcu)
        {
            repository.Add(futbolcu);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Futbolcu futbolcu = repository.GetById(id);
            return View(futbolcu);
        }

        [HttpPost]
        public IActionResult Update(Futbolcu futbolcu)
        {
            repository.Update(futbolcu);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Futbolcu futbolcu = repository.GetById(id);
            repository.Delete(futbolcu);
            return RedirectToAction("Index");
        }
    }
}
