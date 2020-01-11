using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogoCDs.Models;
using CatalogoCDs.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatalogosCDs.Controllers
{
    public class CatalogosController : Controller
    {

        private readonly CDService _cdService;
       
        public CatalogosController(CDService cDService)
        {
            _cdService = cDService;       
        }
        public IActionResult Index()
        {     
            var list = _cdService.FindAll();
            return View(list);
        }

        //Metodo Get para chamar a view do formulario de criar CD
        public IActionResult Criar()
        {
            return View();
        }

        //Metodo POST para inserir o novo cd
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(CD cd)
        {
            _cdService.Insert(cd);
            return RedirectToAction(nameof(Index));
        }
    }
}