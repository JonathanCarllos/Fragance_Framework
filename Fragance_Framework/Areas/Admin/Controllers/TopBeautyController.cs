using Fragance_Framework.Areas.Admin.Models;
using Fragance_Framework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace Fragance_Framework.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TopBeautyController : Controller
    {
        private readonly AppDbContext _context;

        public TopBeautyController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TopBeauty.ToListAsync();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TopBeautyId,CodInternoAvulso,Linha,DescProduto,UnidadeSolto,Cartucho,CaixaEmbalagem,UnidadeBlister,Cartucho12," +
            "CaixaEmbalagem144,NumProcesso,NCM,QtdCaixa,QtdCartucho,Altura,Largura,Profundidade,Peso,Altura2,Largura2,Profundidade2,Peso2," +
            "Altura3,Largura3,Profundidade,Peso3,Altura4,Largura4,Profundidade4,Peso4")]TopBeauty topBeauty)
        {
            if (ModelState.IsValid)
            {
                _context.TopBeauty.Add(topBeauty);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(topBeauty);
        }
    }

}
