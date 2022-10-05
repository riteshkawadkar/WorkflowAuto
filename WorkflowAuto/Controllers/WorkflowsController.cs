using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkflowAuto.Data;

namespace WorkflowAuto.Controllers
{
    [Authorize]
    public class WorkflowsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkflowsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Workflows
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Workflows.Include(w => w.Application);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Workflows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Workflows == null)
            {
                return NotFound();
            }

            var workflow = await _context.Workflows
                .Include(w => w.Application)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workflow == null)
            {
                return NotFound();
            }

            return View(workflow);
        }

        // GET: Workflows/Create
        public IActionResult Create()
        {
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id");
            return View();
        }

        // POST: Workflows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,WorkflowType,ApplicationId,AssociatedRoles,DeliveryRole,Id,DateCreated,DateModified")] Workflow workflow)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workflow);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id", workflow.ApplicationId);
            return View(workflow);
        }

        // GET: Workflows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Workflows == null)
            {
                return NotFound();
            }

            var workflow = await _context.Workflows.FindAsync(id);
            if (workflow == null)
            {
                return NotFound();
            }
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id", workflow.ApplicationId);
            return View(workflow);
        }

        // POST: Workflows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,WorkflowType,ApplicationId,AssociatedRoles,DeliveryRole,Id,DateCreated,DateModified")] Workflow workflow)
        {
            if (id != workflow.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workflow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkflowExists(workflow.Id))
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
            ViewData["ApplicationId"] = new SelectList(_context.Applications, "Id", "Id", workflow.ApplicationId);
            return View(workflow);
        }

        // GET: Workflows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Workflows == null)
            {
                return NotFound();
            }

            var workflow = await _context.Workflows
                .Include(w => w.Application)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workflow == null)
            {
                return NotFound();
            }

            return View(workflow);
        }

        // POST: Workflows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Workflows == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Workflows'  is null.");
            }
            var workflow = await _context.Workflows.FindAsync(id);
            if (workflow != null)
            {
                _context.Workflows.Remove(workflow);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkflowExists(int id)
        {
          return _context.Workflows.Any(e => e.Id == id);
        }
    }
}
