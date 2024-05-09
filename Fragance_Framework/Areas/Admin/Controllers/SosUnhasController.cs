using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SosUnhasController : Controller
    {
        private readonly AppDbContext _context;

        public SosUnhasController(AppDbContext context)
        {
            _context = context;
        }

        private bool SosUnhasExists(int Id)
        {
            return _context.SosUnhas.Any(e => e.SosUnhasId == Id);
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.SosUnhas.ToListAsync();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SosUnhasId,CodInterno,Linha,DescProdutos,DescProdutoFiscal,UnidadeSolto," +
            "Cartucho,CaixaEmbalagem,NumProcesso,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso,Altura2,Largura2,Profundidade2,Peso2," +
            "Altura3,Largura3,Profundidade3,Peso3,Altura4,Largura4,Profundidade4,Peso4")]SosUnhas sosUnhas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sosUnhas);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sosUnhas);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var editar = await _context.SosUnhas.FindAsync(Id);

            if (editar == null)
            {
                return NotFound();
            }
            return View(editar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("SosUnhasId,CodInterno,Linha,DescProdutos,DescProdutoFiscal,UnidadeSolto," +
            "Cartucho,CaixaEmbalagem,NumProcesso,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso,Altura2,Largura2,Profundidade2,Peso2," +
            "Altura3,Largura3,Profundidade3,Peso3,Altura4,Largura4,Profundidade4,Peso4")] SosUnhas sosUnhas)
        {
            if (Id != sosUnhas.SosUnhasId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sosUnhas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SosUnhasExists(sosUnhas.SosUnhasId))
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
            return View(sosUnhas);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var detalhes = await _context.SosUnhas.FirstOrDefaultAsync(m => m.SosUnhasId == Id);
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

            var delete = await _context.SosUnhas.FindAsync(Id);
            if(delete == null)
            {
                return NotFound();
            }
            return View(delete);
        }

        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmado(int? Id)
        {
            var delete = await  _context.SosUnhas.FindAsync(Id);
            _context.SosUnhas.Remove(delete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
