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
    }
}
