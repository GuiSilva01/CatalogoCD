using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}