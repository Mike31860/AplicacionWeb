using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiguelRomeroWeb.Models;

namespace MiguelRomeroWeb.Controllers
{
    public class InformacionController : Controller
    {
        private readonly MiguelRomeroWebContext _context;

        public InformacionController(MiguelRomeroWebContext context)
        {
            _context = context;
        }

        // GET: Informacion
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClienteInfo.ToListAsync());
        }

        // GET: Informacion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteInfo = await _context.ClienteInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clienteInfo == null)
            {
                return NotFound();
            }

            return View(clienteInfo);
        }

        // GET: Informacion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Informacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Necesidad,TipoEvento,Donde,Cuantos")] ClienteInfo clienteInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clienteInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clienteInfo);
        }

        // GET: Informacion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteInfo = await _context.ClienteInfo.FindAsync(id);
            if (clienteInfo == null)
            {
                return NotFound();
            }
            return View(clienteInfo);
        }

        // POST: Informacion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Necesidad,TipoEvento,Donde,Cuantos")] ClienteInfo clienteInfo)
        {
            if (id != clienteInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clienteInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteInfoExists(clienteInfo.Id))
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
            return View(clienteInfo);
        }

        // GET: Informacion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteInfo = await _context.ClienteInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clienteInfo == null)
            {
                return NotFound();
            }

            return View(clienteInfo);
        }

        // POST: Informacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clienteInfo = await _context.ClienteInfo.FindAsync(id);
            _context.ClienteInfo.Remove(clienteInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteInfoExists(int id)
        {
            return _context.ClienteInfo.Any(e => e.Id == id);
        }
    }
}
