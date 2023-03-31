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
    public class LeadStatusController : Controller
    {
        private readonly IRepository<LeadStatus> _leadStatusRepository;

        public LeadStatusController(IRepository<LeadStatus> leadStatusRepository)
        {
            _leadStatusRepository = leadStatusRepository;
        }

        // GET: LeadStatus
        public async Task<IActionResult> Index()
        {
            return View(await _leadStatusRepository.GetAllAsync());
                          
        }

        // GET: LeadStatus/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var leadStatus = await _leadStatusRepository.GetbyIdAsync(id);
            if (leadStatus == null)
            {
                return NotFound();
            }

            return View(leadStatus);
        }

        // GET: LeadStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeadStatus/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LeadStatus_Id,LeadStatusName")] LeadStatus leadStatus)
        {
            if (ModelState.IsValid)
            {
                leadStatus.LeadStatus_Id = Guid.NewGuid();
                await _leadStatusRepository.CreateAsync(leadStatus);
                return RedirectToAction(nameof(Index));
            }
            return View(leadStatus);
        }

        // GET: LeadStatus/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var leadStatus = await _leadStatusRepository.GetbyIdAsync(id);
            if (leadStatus == null)
            {
                return NotFound();
            }
            return View(leadStatus);
        }

        // POST: LeadStatus/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("LeadStatus_Id,LeadStatusName")] LeadStatus leadStatus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _leadStatusRepository.UpdateAsync(leadStatus);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeadStatusExists(leadStatus.LeadStatus_Id))
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
            return View(leadStatus);
        }

        // GET: LeadStatus/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var leadStatus = await _leadStatusRepository.GetbyIdAsync(id);
            if (leadStatus == null)
            {
                return NotFound();
            }

            return View(leadStatus);
        }

        // POST: LeadStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_leadStatusRepository == null)
            {
                return Problem("Entity set 'CRMSDbContext.Statuses'  is null.");
            }
            var leadStatus = await _leadStatusRepository.GetbyIdAsync(id);
            if (leadStatus != null)
            {
                await _leadStatusRepository.DeleteAsync(id);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool LeadStatusExists(Guid id)
        {
          return (_leadStatusRepository.GetbyIdAsync(id) != null);
        }
    }
}
