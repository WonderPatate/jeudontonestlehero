using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestlehero.Core.data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestlehero.backOffice.web.UI.Controllers
{
    public class ParagrapheController : Controller
    {

        private List<Paragraphe> _maList = new List<Paragraphe>()
        {
            new Paragraphe () { Id=1, Numero=2, Description="Ma Description", Titre="Mon titre" },
        new Paragraphe() { Id = 2, Numero = 58, Description = "Ma Description", Titre = "Mon titre" },
            new Paragraphe () { Id=3, Numero=48, Description="Ma Description", Titre="Mon titre" },
            new Paragraphe () { Id=4, Numero=12, Description="Ma Description", Titre="Mon titre" }
        };

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;

            paragraphe = _maList.First(item => item.Id == id);
            return View(paragraphe);
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
