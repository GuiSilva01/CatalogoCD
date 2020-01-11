using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogoCDs.Models;
using CatalogoCDs.Models.ViewModels;
using CatalogoCDs.Services;
using CatalogoCDs.Services.Exceptions;
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
        public async Task<IActionResult> Index()
        {     
            var list = await _cdService.FindAllAsync();
            return View(list);
        }

        //Metodo Get para chamar a view do formulario de criar CD (Criar)
        public async Task<IActionResult> Criar()
        {
            var gravadora = await _gravadoraService.FindAllAsync();
            var faixadePreco = await _faixaService.FindAllAsync();
            var musica = await _musicaService.FindAllAsync();
            var viewModel = new CDFormViewModel { Gravadoras = gravadora, FaixadePrecos = faixadePreco, Musicas = musica, };
            return View(viewModel);
        }

        //Metodo POST para inserir o novo cd (Criar)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(CD cd)
        {
            await _cdService.InsertAsync(cd);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Deletar(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = await _cdService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deletar(int id)
        {
            await _cdService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = await _cdService.FindByIdAsync(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            List<Gravadora> gravadoras = await _gravadoraService.FindAllAsync();
            List<FaixadePreco> faixadePrecos = await _faixaService.FindAllAsync();
            List<Musica> musicas = await _musicaService.FindAllAsync();
            CDFormViewModel viewModel = new CDFormViewModel { CD = obj, Gravadoras = gravadoras, FaixadePrecos = faixadePrecos, Musicas = musicas };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, CD cd)
        {
            if(id != cd.Id)
            {
                return BadRequest();
            }
            try { 
            await _cdService.UpdateAsync(cd);
            return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }

        }
    }
}