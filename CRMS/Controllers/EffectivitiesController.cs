﻿using System;
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
    public class EffectivitiesController : Controller
    {
        private readonly IRepository<Effectivity> _effectivityRepository;

        public EffectivitiesController(IRepository<Effectivity> effectivityRepository)
        {
            _effectivityRepository = effectivityRepository;
        }

        // GET: Effectivities
        public async Task<IActionResult> Index()
        {
            return View(await _effectivityRepository.GetAllAsync());
        }

        // GET: Effectivities/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var effectivity = await _effectivityRepository.GetbyIdAsync(id);
            if (effectivity == null)
            {
                return NotFound();
            }

            return View(effectivity);
        }

        // GET: Effectivities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Effectivities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Effectivity_Id,Effectivity_Name")] Effectivity effectivity)
        {
            if (ModelState.IsValid)
            {
                effectivity.Effectivity_Id = Guid.NewGuid();
                await _effectivityRepository.CreateAsync(effectivity);
                return RedirectToAction(nameof(Index));
            }
            return View(effectivity);
        }

        // GET: Effectivities/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var effectivity = await _effectivityRepository.GetbyIdAsync(id);
            if (effectivity == null)
            {
                return NotFound();
            }
            return View(effectivity);
        }

        // POST: Effectivities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Effectivity_Id,Effectivity_Name")] Effectivity effectivity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _effectivityRepository.UpdateAsync(effectivity);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EffectivityExists(effectivity.Effectivity_Id))
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
            return View(effectivity);
        }

        // GET: Effectivities/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var effectivity = await _effectivityRepository.GetbyIdAsync(id);
            if (effectivity == null)
            {
                return NotFound();
            }

            return View(effectivity);
        }

        // POST: Effectivities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_effectivityRepository == null)
            {
                return Problem("Entity set 'CRMSDbContext.Effectivity'  is null.");
            }
            var effectivity = await _effectivityRepository.GetbyIdAsync(id);
            if (effectivity != null)
            {
                await _effectivityRepository.DeleteAsync(id);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool EffectivityExists(Guid id)
        {
          return (_effectivityRepository.GetbyIdAsync(id) is not null);
        }
    }
}
