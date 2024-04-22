using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MaquiagensController : Controller
    {
        private readonly AppDbContext _context;

        private bool MaquiagensExists(int id)
        {
            return _context.Maquiagens.Any(e => e.MaquiagensId == id);
        }

        public MaquiagensController(AppDbContext context)
        {
            _context = context;
        }

        //Lista
        public async Task<IActionResult> Index()
        {
            var Lista = await _context.Maquiagens.ToListAsync();
            return View(Lista);
        }

        //Detalhes
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Detalhes = await _context.Maquiagens.FirstOrDefaultAsync(m => m.MaquiagensId == id);
            if (Detalhes == null)
            {
                return NotFound();
            }

            return View(Detalhes);
        }

        //criar
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaquiagensId,CodInterno,Linha,Cor,DescricaoProdutoFiscal,UnidadeSolto,Cartucho,CaixaEmbarque,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso")] Maquiagens maquiagens)
        {
            if (ModelState.IsValid)
            {
                _context.Maquiagens.Add(maquiagens);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(maquiagens);

        }

        //edit
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var editar = await _context.Maquiagens.FindAsync(Id);
            if (editar == null)
            {
                return NotFound();
            }

            return View(editar);
        }

        //postEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaquiagensId,CodInterno,Linha,Cor,DescricaoProdutoFiscal,UnidadeSolto,Cartucho,CaixaEmbarque,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso")] Maquiagens maquiagens)
        {
            if (id != maquiagens.MaquiagensId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maquiagens);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaquiagensExists(maquiagens.MaquiagensId))
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
            return View(maquiagens);
        }

        //Delete HttpGet
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delete = await _context.Maquiagens.FindAsync(id);

            if (delete == null)
            {
                return NotFound();
            }

            return View(delete);
        }

        //DeletePost
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmado(int? id)
        {
            var delete = await _context.Maquiagens.FindAsync(id);
            _context.Maquiagens.Remove(delete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
