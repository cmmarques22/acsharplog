using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockManagement.api.Models;

namespace StockManagement.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliesController : ControllerBase
    {
        private readonly FamilyManagementContext _context;

        public FamiliesController(StockManagementContext context)
        {
            _context = context;
        }

        // GET: Families
        public async Task<IActionResult> Index()
        {
            return View(await _context.Families.ToListAsync());
        }

        // GET: Families/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var family = await _context.Families
                .FirstOrDefaultAsync(m => m.FamilyId == id);
            if (family == null)
            {
                return NotFound();
            }

            return View(family);
        }

        // GET: Families/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FamilyId,FamilyName,InsertUserId,InsertDateTime,LastModifiedUserId,LastModifiedDateTime")] Family family)
        {
            if (ModelState.IsValid)
            {
                _context.Add(family);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(family);
        }

        // GET: Families/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var family = await _context.Families.FindAsync(id);
            if (family == null)
            {
                return NotFound();
            }
            return View(family);
        }

        // POST: Families/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FamilyId,FamilyName,InsertUserId,InsertDateTime,LastModifiedUserId,LastModifiedDateTime")] Family family)
        {
            if (id != family.FamilyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(family);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamilyExists(family.FamilyId))
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
            return View(family);
        }

        // GET: Families/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var family = await _context.Families
                .FirstOrDefaultAsync(m => m.FamilyId == id);
            if (family == null)
            {
                return NotFound();
            }

            return View(family);
        }

        // POST: Families/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var family = await _context.Families.FindAsync(id);
            if (family != null)
            {
                _context.Families.Remove(family);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FamilyExists(string id)
        {
            return _context.Families.Any(e => e.FamilyId == id);
        }
    }
}
