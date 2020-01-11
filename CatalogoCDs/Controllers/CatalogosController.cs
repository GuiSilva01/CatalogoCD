using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogoCDs.Models;
using CatalogoCDs.Models.ViewModels;
using CatalogoCDs.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatalogosCDs.Controllers
{
    public class CatalogosController : Controller
    {

        private readonly CDService _cdService;
        private readonly FaixadePrecoService _faixaService;
        private readonly GravadoraService _gravadoraService;
        private readonly MusicaService _musicaService;

        public CatalogosController(CDService cDService, FaixadePrecoService faixadePreco, GravadoraService gravadoraService, MusicaService musicaService)
        {
            _cdService = cDService;
            _faixaService = faixadePreco;
            _gravadoraService = gravadoraService;
            _musicaService = musicaService;
        }
        public IActionResult Index()
        {     
            var list = _cdService.FindAll();
            return View(list);
        }

        //Metodo Get para chamar a view do formulario de criar CD (Criar)
        public IActionResult Criar()
        {
            var gravadora = _gravadoraService.FindAll();
            var faixadePreco = _faixaService.FindAll();
            var musica = _musicaService.FindAll();
            var viewModel = new CDFormViewModel { Gravadoras = gravadora, FaixadePrecos = faixadePreco, Musicas = musica, };
            return View(viewModel);
        }

        //Metodo POST para inserir o novo cd (Criar)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(CD cd)
        {
            _cdService.Insert(cd);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _cdService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(int id)
        {
            _cdService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}