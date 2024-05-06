using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RabisqueNovoController : Controller
    {
        private readonly AppDbContext _context;

        private bool RabisqueNovoExist(int Id)
        {
            return _context.RabisqueNovos.Any(m => m.RabisqueNovoId == Id);
        }

        public RabisqueNovoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.RabisqueNovos.ToListAsync();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RabisqueNovoId,CodSistema,Linha,DescProduto,DescProdutoFiscal,UnidadeSolto," +
            "Cartucho,CaixaEmbalagem,NumProcesso,QtdCaixa,QtdCartucho,NCM")] RabisqueNovo rabisqueNovo)
        {
            if (ModelState.IsValid)
            {
                _context.RabisqueNovos.Add(rabisqueNovo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(rabisqueNovo);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var editar = await _context.RabisqueNovos.FindAsync(Id);

            if (editar == null)
            {
                return NotFound();
            }

            return View(editar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? Id, [Bind("RabisqueNovoId,CodSistema,Linha,DescProduto,DescProdutoFiscal,UnidadeSolto," +
            "Cartucho,CaixaEmbalagem,NumProcesso,QtdCaixa,QtdCartucho,NCM")] RabisqueNovo rabisqueNovo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rabisqueNovo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RabisqueNovoExist(rabisqueNovo.RabisqueNovoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rabisqueNovo);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }

            var detalhes = await _context.RabisqueNovos.FirstOrDefaultAsync(m => m.RabisqueNovoId == Id);

            if(detalhes == null)
            {
                return NotFound();
            }

            return View(detalhes);
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var delete = await _context.RabisqueNovos.FindAsync(Id);

            if (delete == null)
            {
                return NotFound();
            }

            return View(delete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmado(int? Id)
        {
            var delete = await _context.RabisqueNovos.FindAsync(Id);
            _context.RabisqueNovos.Remove(delete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
