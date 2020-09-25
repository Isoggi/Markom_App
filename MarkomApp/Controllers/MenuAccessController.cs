using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarkomApp.Data;
using MarkomApp.Models;

namespace MarkomApp.Controllers
{
    public class MenuAccessController : Controller
    {
        private readonly DataContext _context;

        public MenuAccessController(DataContext context)
        {
            _context = context;
        }

        // GET: MenuAccess
        public async Task<IActionResult> Index()
        {
            return View(await _context.MenuAccesses.ToListAsync());
        }

        // GET: MenuAccess/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuAccess = await _context.MenuAccesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuAccess == null)
            {
                return NotFound();
            }

            return View(menuAccess);
        }

        // GET: MenuAccess/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MenuAccess/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MRoleId,MMenuId,IsDelete,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] MenuAccess menuAccess)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menuAccess);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(menuAccess);
        }

        // GET: MenuAccess/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuAccess = await _context.MenuAccesses.FindAsync(id);
            if (menuAccess == null)
            {
                return NotFound();
            }
            return View(menuAccess);
        }

        // POST: MenuAccess/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MRoleId,MMenuId,IsDelete,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] MenuAccess menuAccess)
        {
            if (id != menuAccess.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menuAccess);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuAccessExists(menuAccess.Id))
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
            return View(menuAccess);
        }

        // GET: MenuAccess/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuAccess = await _context.MenuAccesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuAccess == null)
            {
                return NotFound();
            }

            return View(menuAccess);
        }

        // POST: MenuAccess/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menuAccess = await _context.MenuAccesses.FindAsync(id);
            _context.MenuAccesses.Remove(menuAccess);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuAccessExists(int id)
        {
            return _context.MenuAccesses.Any(e => e.Id == id);
        }
    }
}
