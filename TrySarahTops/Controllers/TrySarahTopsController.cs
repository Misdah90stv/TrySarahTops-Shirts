using Microsoft.AspNetCore.Mvc;
using TrySarahTops.Models;


namespace TrySarahTops.Controllers
{
    public class ShirtsController : Controller
    {

        //Create
        [HttpGet]
        public IActionResult Add()
        {
            return RedirectToAction("Details");
        }

        [HttpPost]
        public IActionResult Add(Shirt s)
        {
            return View();
        }
        //Read
        public IActionResult Details(int id)
        {
            Shirt s = new Shirt();
            s.Id = 1;
            s.Color = "Red";
            s.Size = "Medium";
            s.Letter = 'A';
            s.ColorofLetter = "Yellow";
            s.TypeofShirt = "Short Sleeve";
            return View(s);
        }


        //Update

        [HttpGet] 
        public IActionResult Edit(int id)
        {
            Shirt s = new Shirt();
            s.Id = 1;
            s.Color = "Red";
            s.Size = "Medium";
            s.Letter = 'A';
            s.ColorofLetter = "Yellow";
            s.TypeofShirt = "Short Sleeve";
            return View(s);
        }
       
        [HttpPost]
        public IActionResult Edit(Shirt s)
        {
            return RedirectToAction("Details");
        }
        //Delete

    }
}

