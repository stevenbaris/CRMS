using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRMS.Data;
using CRMS.Models;
using CRMS.Services;

namespace CRMS.Controllers
{
    public class SourcesController : Controller
    {
        private readonly IRepository<Source> _sourceRepository;

        public SourcesController(IRepository<Source> sourceRepository)
        {
            _sourceRepository = sourceRepository;
        }

        // GET: Sources
        public async Task<IActionResult> Index()
        {
            return View(await _sourceRepository.GetAllAsync());
                         
        }

        // GET: Sources/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var source = await _sourceRepository.GetbyIdAsync(id);
            if (source == null)
            {
                return NotFound();
            }

            return View(source);
        }

        // GET: Sources/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sources/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Source_Id,SourceName")] Source source)
        {
            if (ModelState.IsValid)
            {
                source.Source_Id = Guid.NewGuid();
                await _sourceRepository.CreateAsync(source);
                return RedirectToAction(nameof(Index));
            }
            return View(source);
        }

        // GET: Sources/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {

            var source = await _sourceRepository.GetbyIdAsync(id);
            if (source == null)
            {
                return NotFound();
            }
            return View(source);
        }

        // POST: Sources/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Source_Id,SourceName")] Source source)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _sourceRepository.UpdateAsync(source);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SourceExists(source.Source_Id))
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
            return View(source);
        }

        // GET: Sources/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var source = await _sourceRepository.GetbyIdAsync(id);
            if (source == null)
            {
                return NotFound();
            }

            return View(source);
        }

        // POST: Sources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_sourceRepository == null)
            {
                return Problem("Entity set 'CRMSDbContext.Sources'  is null.");
            }
            var source = await _sourceRepository.GetbyIdAsync(id);
            if (source != null)
            {
                await _sourceRepository.DeleteAsync(id);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool SourceExists(Guid id)
        {
          return (_sourceRepository.GetbyIdAsync(id) is not null);
        }
    }
}
