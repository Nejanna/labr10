using labr10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace laboratory10.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult CreateForm() => View();

        [HttpPost]
        public IActionResult Luck(FliedDataModel model)
        {
            if (DateTime.Now.Date >= model.Date.Date || model.Date.DayOfWeek == DayOfWeek.Saturday || model.Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    ModelState.AddModelError("Date", "Бажана дата повинна бути в майбутньому та не попадати на вихідні");
                }

            if (model.Product == "Основи" && model.Date.DayOfWeek == DayOfWeek.Monday)
            {
                ModelState.AddModelError("Date", "Консультація щодо продукту «Основи» не може проходити по понеділках");
            }

            if (!ModelState.IsValid)
            {
                return View("CreateForm", model);
            }

            return View("Luck");
        }
        }


   
}