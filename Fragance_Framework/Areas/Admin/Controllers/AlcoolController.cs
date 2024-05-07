using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AlcoolController : Controller
    {
        private readonly AppDbContext _context;

        public AlcoolController(AppDbContext context)
        {
            _context = context;
        }

        private bool AlcoolExists(int Id)
        {
            return _context.Alcool.Any(e => e.AlcoolId == Id);
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.Alcool.ToListAsync();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlcoolId,CodSistema,Linha,Fragancia,DescProdutoFiscal,UnidadeSolto," +
            "Cartucho,CaixaEmbalagem,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso")] Alcool alcool)
        {
            if (ModelState.IsValid)
            {
                var criar = _context.Alcool.Add(alcool);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(alcool);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var editar = await _context.Alcool.FindAsync(Id);
            if (Id == null)
            {
                return NotFound();
            }
            return View(editar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("AlcoolId,CodSistema,Linha,Fragancia,DescProdutoFiscal,UnidadeSolto," +
            "Cartucho,CaixaEmbalagem,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso")] Alcool alcool)
        {
            if (Id != alcool.AlcoolId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alcool);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlcoolExists(alcool.AlcoolId))
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
            return View(alcool);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var detalhes = await _context.Alcool.FirstOrDefaultAsync(m => m.AlcoolId == Id);
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

            var delete = await _context.Alcool.FindAsync(Id);
            if(delete == null)
            {
                return NotFound();
            }
            return View(delete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmado(int? Id)
        {
            var delete = await _context.Alcool.FindAsync(Id);
            _context.Alcool.Remove(delete);
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
