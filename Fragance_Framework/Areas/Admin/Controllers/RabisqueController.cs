using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RabisqueController : Controller
    {
        private readonly AppDbContext _context;

        public RabisqueController(AppDbContext context)
        {
            _context = context;
        }

        private bool RabisqueExists(int id)
        {
            return _context.Rabisque.Any(e => e.RabisqueId == id);
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.Rabisque.ToListAsync();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RabisqueId,CodSistema,Linha,DescProduto,DescProdutoFiscal,UnidadeSolto," +
            "Cartucho,CaixaEmbalagem,NumProcesso,QtdCaixa,QtdCartucho,NCM")] Rabisque rabisque)
        {
            if (ModelState.IsValid)
            {
                _context.Rabisque.Add(rabisque);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(rabisque);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var editar = await _context.Rabisque.FindAsync(Id);
            if (editar == null)
            {
                return NotFound();
            }

            return View(editar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("RabisqueId,CodSistema,Linha,DescProduto,DescProdutoFiscal,UnidadeSolto," +
            "Cartucho,CaixaEmbalagem,NumProcesso,QtdCaixa,QtdCartucho,NCM")] Rabisque rabisque)
        {
            if (Id != rabisque.RabisqueId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rabisque);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RabisqueExists(rabisque.RabisqueId))
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
            return View(rabisque);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var detalhes = await _context.Rabisque.FirstOrDefaultAsync(d => d.RabisqueId == Id);

            if (detalhes == null)
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

            var delete = await _context.Rabisque.FindAsync(Id);
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
            var delete = await _context.Rabisque.FindAsync(Id);
            _context.Rabisque.Remove(delete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}