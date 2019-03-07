using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OldApp_Adapter.Models;
using OldApp_Adapter.Models.Adapter;
using OldApp_Adapter.Models.Target;

namespace OldApp_Adapter.Controllers
{
    public class HomeController : Controller
    {
        //BazaDanychContext baza = new BazaDanychContext();
        IStudentRepo adapter = new StudentRepo(new BazaDanychContext());
        public IActionResult Index()
        {
            //List<Student> model = baza.Studenci.ToList();
            List<Student> model = adapter.GetList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = baza.Studenci.Where(s => s.Id == id).FirstOrDefault();
            baza.Studenci.Remove(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            baza.Studenci.Add(student);    
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Add()
        {           
            return View("Dodaj");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
