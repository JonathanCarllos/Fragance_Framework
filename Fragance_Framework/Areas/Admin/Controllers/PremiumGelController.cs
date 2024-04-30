using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    public class PremiumGelController : Controller
    {
        private readonly AppDbContext _context;

        private bool PremiumGelExists(int id)
        {
            return _context.PremiumGel.Any(e => e.PremiumGelId == id);
        }

        public PremiumGelController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _context.PremiumGel.ToListAsync();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PremiumGelId,CodSistema,Linha,DescProduto,DescProdutoFiscal,UnidadeSolto,Cartucho,CaixaEmbalagem," +
            "NumProcesso,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso")] PremiumGel premiumGel)
        {
            if (ModelState.IsValid)
            {
                var criar = _context.PremiumGel.Add(premiumGel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(premiumGel);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var editar = await _context.PremiumGel.FindAsync(Id);
            if (editar == null)
            {
                return NotFound();
            }

            return View(editar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("PremiumGelId,CodSistema,Linha,DescProduto,DescProdutoFiscal,UnidadeSolto,Cartucho,CaixaEmbalagem," +
            "NumProcesso,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso")]PremiumGel premiumGel)
        {
            if (Id != premiumGel.PremiumGelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(premiumGel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PremiumGelExists(premiumGel.PremiumGelId))
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
            return View(premiumGel);
        }
    }
}
