using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRMS.Data;
using CRMS.Services;
using CRMS.Models.Customization;

namespace CRMS.Controllers
{
    public class EngagementTypesController : Controller
    {
        private readonly IRepository<EngagementType> _engagementTypeRepo;

        public EngagementTypesController(IRepository<EngagementType> engagementTypeRepo)
        {
            _engagementTypeRepo = engagementTypeRepo;
        }

        // GET: EngagementTypes
        public async Task<IActionResult> Index()
        {
            return View(await _engagementTypeRepo.GetAllAsync());
                          
        }

        // GET: EngagementTypes/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var engagementType = await _engagementTypeRepo.GetbyIdAsync(id);
            if (engagementType == null)
            {
                return NotFound();
            }

            return View(engagementType);
        }

        // GET: EngagementTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EngagementTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EType_Id,EngagementName")] EngagementType engagementType)
        {
            if (ModelState.IsValid)
            {
                engagementType.EType_Id = Guid.NewGuid();
                await _engagementTypeRepo.CreateAsync(engagementType);
                return RedirectToAction(nameof(Index));
            }
            return View(engagementType);
        }

        // GET: EngagementTypes/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var engagementType = await _engagementTypeRepo.GetbyIdAsync(id);
            if (engagementType == null)
            {
                return NotFound();
            }
            return View(engagementType);
        }

        // POST: EngagementTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("EType_Id,EngagementName")] EngagementType engagementType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _engagementTypeRepo.UpdateAsync(engagementType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EngagementTypeExists(engagementType.EType_Id))
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
            return View(engagementType);
        }

        // GET: EngagementTypes/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var engagementType = await _engagementTypeRepo.GetbyIdAsync(id);
            if (engagementType == null)
            {
                return NotFound();
            }

            return View(engagementType);
        }

        // POST: EngagementTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_engagementTypeRepo == null)
            {
                return Problem("Entity set 'CRMSDbContext.EngagementTypes'  is null.");
            }
            var engagementType = await _engagementTypeRepo.GetbyIdAsync(id);
            if (engagementType != null)
            {
                await _engagementTypeRepo.DeleteAsync(id);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool EngagementTypeExists(Guid id)
        {
          return (_engagementTypeRepo.GetbyIdAsync(id) is not null);
        }
    }
}
