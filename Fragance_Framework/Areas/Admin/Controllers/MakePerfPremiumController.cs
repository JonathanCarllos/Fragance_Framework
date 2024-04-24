using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MakePerfPremiumController : Controller
    {
        private readonly AppDbContext _context;

        private bool MakePerfExists(int id)
        {
            return _context.MakePerfPremium.Any(e => e.MakePerfPremiumId == id);
        }

        public MakePerfPremiumController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.MakePerfPremium.ToListAsync();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MakePerfPremiumId, CodInternoAvulso, Linha, Cor, DescProdutoFiscal, UnidadeSolto, Cartucho, CaixaEmbarque, NCM, NumProcesso, QtdCaixa, QtdCartucho, Altura, Largura,Profundidade, Peso")] MakePerfPremium make_Perf_Premium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(make_Perf_Premium);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(make_Perf_Premium);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var editar = await _context.MakePerfPremium.FindAsync(Id);
            if (editar == null)
            {
                return NotFound();
            }
            return View(editar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("MakePerfPremiumId, CodInternoAvulso, Linha, Cor, DescProdutoFiscal, UnidadeSolto, Cartucho, CaixaEmbarque, NCM, NumProcesso, QtdCaixa, QtdCartucho, Altura, Largura,Profundidade, Peso")] MakePerfPremium makePerf)
        {
            if (Id != makePerf.MakePerfPremiumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(makePerf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MakePerfExists(makePerf.MakePerfPremiumId))
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
            return View(makePerf);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var detalhes = await _context.MakePerfPremium.FirstOrDefaultAsync(d => d.MakePerfPremiumId == Id);
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

            var delete = await _context.MakePerfPremium.FindAsync(Id);

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
            var delete = await _context.MakePerfPremium.FindAsync(Id);
            _context.MakePerfPremium.Remove(delete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
