using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fragance_Framework.Context;
using Fragance_Framework.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Fragance_Framework.Controllers
{
    [Authorize(Roles = "User")]
    public class EnvasesController : Controller
    {
        private readonly AppDbContext _context;

        public EnvasesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Envases
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
              return _context.EnvasesSetup != null ? 
                          View(await _context.EnvasesSetup.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.EnvasesSetup'  is null.");
        }

        // GET: Envases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EnvasesSetup == null)
            {
                return NotFound();
            }

            var envase = await _context.EnvasesSetup
                .FirstOrDefaultAsync(m => m.EnvaseSetupId == id);
            if (envase == null)
            {
                return NotFound();
            }

            return View(envase);
        }

        // GET: Envases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Envases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnvaseSetupId,Nome,Produto,Equipe,Funcao,Data,Maquina,Frasco,Tampa,Responsavel,Polivalente,Referencia,Categoria,QtdPrevista,LoteNumEnvase,Validade,CorCodTampa,Intercorrencia,Observacao,HoraInicial,HoraFinal,QtdFinal,LimpezaInicio,LimpezaFinal,CodBulkGranel,HorarioAquecimentoFusor,Processo,DescricaoIntercorrencia,ProducaoLiberada")] Envase envase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(envase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(envase);
        }

        // GET: Envases/Edit/5
        [AllowAnonymous]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EnvasesSetup == null)
            {
                return NotFound();
            }

            var envase = await _context.EnvasesSetup.FindAsync(id);
            if (envase == null)
            {
                return NotFound();
            }
            return View(envase);
        }

        // POST: Envases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Edit(int id, [Bind("EnvaseSetupId,Nome,Produto,Equipe,Funcao,Data,Maquina,Frasco,Tampa,Responsavel,Polivalente,Referencia,Categoria,QtdPrevista,LoteNumEnvase,Validade,CorCodTampa,Intercorrencia,Observacao,HoraInicial,HoraFinal,QtdFinal,LimpezaInicio,LimpezaFinal,CodBulkGranel,HorarioAquecimentoFusor,Processo,DescricaoIntercorrencia,ProducaoLiberada")] Envase envase)
        {
            if (id != envase.EnvaseSetupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(envase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnvaseExists(envase.EnvaseSetupId))
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
            return View(envase);
        }

        // GET: Envases/Delete/5
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EnvasesSetup == null)
            {
                return NotFound();
            }

            var envase = await _context.EnvasesSetup
                .FirstOrDefaultAsync(m => m.EnvaseSetupId == id);
            if (envase == null)
            {
                return NotFound();
            }

            return View(envase);
        }

        // POST: Envases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EnvasesSetup == null)
            {
                return Problem("Entity set 'AppDbContext.EnvasesSetup'  is null.");
            }
            var envase = await _context.EnvasesSetup.FindAsync(id);
            if (envase != null)
            {
                _context.EnvasesSetup.Remove(envase);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnvaseExists(int id)
        {
          return (_context.EnvasesSetup?.Any(e => e.EnvaseSetupId == id)).GetValueOrDefault();
        }
    }
}