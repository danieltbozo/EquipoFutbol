using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquipoFutbol1.Data;
using EquipoFutbol1.Models;

namespace EquipoFutbol1.Controllers
{
    public class JugadoresController : Controller
    {
        private readonly FutbolContext _context;

        public JugadoresController(FutbolContext context)
        {
            _context = context;
        }

        // GET: Jugadores
        public async Task<IActionResult> Index()
        {
            var futbolContext = _context.Jugadores.Include(j => j.Equipo);
            return View(await futbolContext.ToListAsync());
        }


        // GET: Jugadores
        public async Task<IActionResult> ListaJugadores(int? id)
        {
            var futbolContext = _context.Jugadores.Where(j => j.IdEquipo == id);
            return View(await futbolContext.ToListAsync());
        }

        // GET: Jugadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugadores
                .Include(j => j.Equipo)
                .SingleOrDefaultAsync(m => m.IdJugador == id);
            if (jugador == null)
            {
                return NotFound();
            }

            return View(jugador);
        }

        // GET: Jugadores/Create
        public IActionResult Create()
        {
            ViewData["IdEquipo"] = new SelectList(_context.Equipos, "IdEquipo", "IdEquipo");
            return View();
        }

        // POST: Jugadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdJugador,NombreJugador,Edad,IdEquipo")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jugador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEquipo"] = new SelectList(_context.Equipos, "IdEquipo", "IdEquipo", jugador.IdEquipo);
            return View(jugador);
        }

        // GET: Jugadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugadores.SingleOrDefaultAsync(m => m.IdJugador == id);
            if (jugador == null)
            {
                return NotFound();
            }
            ViewData["IdEquipo"] = new SelectList(_context.Equipos, "IdEquipo", "IdEquipo", jugador.IdEquipo);
            return View(jugador);
        }

        // POST: Jugadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdJugador,NombreJugador,Edad,IdEquipo")] Jugador jugador)
        {
            if (id != jugador.IdJugador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jugador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JugadorExists(jugador.IdJugador))
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
            ViewData["IdEquipo"] = new SelectList(_context.Equipos, "IdEquipo", "IdEquipo", jugador.IdEquipo);
            return View(jugador);
        }

        // GET: Jugadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugadores
                .Include(j => j.Equipo)
                .SingleOrDefaultAsync(m => m.IdJugador == id);
            if (jugador == null)
            {
                return NotFound();
            }

            return View(jugador);
        }

        // POST: Jugadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jugador = await _context.Jugadores.SingleOrDefaultAsync(m => m.IdJugador == id);
            _context.Jugadores.Remove(jugador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JugadorExists(int id)
        {
            return _context.Jugadores.Any(e => e.IdJugador == id);
        }
    }
}
