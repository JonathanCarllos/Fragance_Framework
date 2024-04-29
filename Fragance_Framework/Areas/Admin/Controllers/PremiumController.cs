using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PremiumController : Controller
    {
        private readonly AppDbContext _context;

        private bool PremiumExists(int id)
        {
            return _context.Premium.Any(e => e.PremiumId == id);
        }

        public PremiumController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var lista = await _context.Premium.ToListAsync();
            return View(lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PremiumId,CodSistema,Linha,DescProduto,DescProdutoFiscal,UnidadeSolto,Cartucho,CaixaEmbalagem," +
            "NumProcesso,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso")] Premium premium)
        {
            if(ModelState.IsValid)
            {
                var criar = _context.Premium.Add(premium);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(premium);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if(Id  == null)
            {
                return NotFound();
            }

            var editar = await _context.Premium.FindAsync(Id);
            if(editar == null)
            {
                return NotFound();
            }

            return View(editar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PremiumId,CodSistema,Linha,DescProduto,DescProdutoFiscal,UnidadeSolto,Cartucho,CaixaEmbalagem," +
            "NumProcesso,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso")]Premium premium)
        {
            if(id != premium.PremiumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(premium);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!PremiumExists(premium.PremiumId))
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
            return View(premium);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }

            var detalhes = await _context.Premium.FirstOrDefaultAsync(m => m.PremiumId == Id);
            if(detalhes == null)
            {
                return NotFound();
            }

            return View(detalhes);
        }

    }
}
