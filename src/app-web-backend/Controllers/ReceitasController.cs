using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_web_backend.Models;

namespace app_web_backend.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReceitasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Receitas
        public async Task<IActionResult> Index(string stringDeBusca)
        {
            var receitas = from r in _context.Receitas
                           select r;


            if (!String.IsNullOrEmpty(stringDeBusca))
            {
                receitas = receitas.Where(s => (s.IngredientePrincipal!.Contains(stringDeBusca) || s.Nome!.Contains(stringDeBusca)));
            }

            // formatar exibicao do modo preparo com tres pontinhos
            await receitas.ForEachAsync(receita => { 
                if (receita.ModoPreparo.Length > 50)
                {
                    var TRES_PONTOS = "...";
                    receita.ModoPreparo = receita.ModoPreparo.Substring(0, 50) + " " +  TRES_PONTOS;
                }
            });


            return View(await receitas.ToListAsync());
        }

        // GET: Receitas de Usuário Logado
        public async Task<IActionResult> MinhasReceitas()
        {
            var receitas = from r in _context.Receitas
                           select r;
            var userId = from u in _context.Usuarios where u.Nome == User.Identity.Name
                         select u.Id;

            if (userId != null)
            {
                var minhasReceitas = receitas.Where(x => x.Autor == userId.First());

                // formatar exibicao do modo preparo com tres pontinhos
                await minhasReceitas.ForEachAsync(receita =>
                {
                    if (receita.ModoPreparo.Length > 50)
                    {
                        var TRES_PONTOS = "...";
                        receita.ModoPreparo = receita.ModoPreparo.Substring(0, 50) + " " + TRES_PONTOS;
                    }
                });

                return View(await minhasReceitas.ToListAsync());

            } else
            {
                ViewData["Message"] = "Compartilhe sua primeira receita!";
                return View();
            }

            
        }

        // GET: Receitas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var userId = from u in _context.Usuarios
                         where u.Nome == User.Identity.Name
                         select u.Id;

            ViewBag.userid = userId;

            if (id == null)
            {
                return NotFound();
            }

            var receita = await _context.Receitas
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }


        // GET: Receitas/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios.Where(u => u.Nome == User.Identity.Name), "Id", "Nome");
            return View();
        }

        // POST: Receitas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nome,IngredientePrincipal,TempoPreparo,ModoPreparo,Autor,Imagem,ContadorFavoritos")] Receita receita)
        {                     
            

            if (ModelState.IsValid)
            {
                _context.Add(receita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           return View(receita);
        }

        // GET: Receitas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
                       

            if (id == null)
            {
                return NotFound();
            }

            var receita = await _context.Receitas.FindAsync(id);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios.Where(u => u.Nome == User.Identity.Name), "Id", "Nome");
            if (receita == null)
            {
                return NotFound();
            }
            return View(receita);
        }

        // POST: Receitas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Codigo,Nome,IngredientePrincipal,TempoPreparo,ModoPreparo,Autor,Imagem,ContadorFavoritos")] Receita receita)
        {
            if (id != receita.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceitaExists(receita.Codigo))
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
            return View(receita);
        }

        // GET: Receitas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receita = await _context.Receitas
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }

        // POST: Receitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receita = await _context.Receitas.FindAsync(id);
            _context.Receitas.Remove(receita);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceitaExists(int id)
        {
            return _context.Receitas.Any(e => e.Codigo == id);
        }
    }
}
