using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExePedroLuiz1.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aluno()
        {
            ViewBag.Best = "Os melhores alunos são aqueles que estudam mais!";
            if (TempData["Teste"] != null)
                ViewData["Estudo"] = "O MVC é um padrão de desenvolvimento muito utilizado no mundo web é conhecido por 'forçar' o programador a separar as responsabilidades";
            return View();
        }

        public ActionResult Estudo()
        {
            TempData["Teste"] = "Enildo mt bom como professor";
            return RedirectToAction("Aluno");
        }
    }
}