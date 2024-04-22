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
        public async Task<IActionResult> Create([Bind("MakePerfPremiumId, CodInternoAvulso, Linha, Cor, DescProdutoFiscal, UnidadeSolto, Cartucho, CaixaEmbarque, NCM, NumProcesso, QtdCaixa, QtdCartucho, Altura, Largura,Profundidade, Peso")]Make_Perf_Premium make_Perf_Premium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(make_Perf_Premium);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(make_Perf_Premium);
        }
    }
}
