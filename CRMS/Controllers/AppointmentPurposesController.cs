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
    public class AppointmentPurposesController : Controller
    {
        private readonly IRepository<AppointmentPurpose> _purposesRepository;
        public AppointmentPurposesController(
            IRepository<AppointmentPurpose> purposesRepository)
        {
            _purposesRepository = purposesRepository;
        }

        // GET: AppointmentPurposes
        public async Task<IActionResult> Index()
        {
            var purposesList = await _purposesRepository.GetAllAsync();
            return View("~/Views/ManageLists/AppointmentPurposes/Index.cshtml", purposesList);
                     
        }

        // GET: AppointmentPurposes/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var appointmentPurpose = await _purposesRepository.GetbyIdAsync(id);
            if (appointmentPurpose == null)
            {
                return NotFound();
            }

            return View("~/Views/ManageLists/AppointmentPurposes/Details.cshtml", appointmentPurpose);
        }

        // GET: AppointmentPurposes/Create
        public IActionResult Create()
        {
            return View("~/Views/ManageLists/AppointmentPurposes/Create.cshtml");
        }

        // POST: AppointmentPurposes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Purpose_Id,PurposeName")] AppointmentPurpose appointmentPurpose)
        {
            if (ModelState.IsValid)
            {
                appointmentPurpose.Purpose_Id = Guid.NewGuid();
                await _purposesRepository.CreateAsync(appointmentPurpose);
                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/ManageLists/AppointmentPurposes/Create.cshtml", appointmentPurpose);
        }

        // GET: AppointmentPurposes/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var appointmentPurpose = await _purposesRepository.GetbyIdAsync(id);
            if (appointmentPurpose == null)
            {
                return NotFound();
            }
            return View("~/Views/ManageLists/AppointmentPurposes/Edit.cshtml", appointmentPurpose);
        }

        // POST: AppointmentPurposes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Purpose_Id,PurposeName")] AppointmentPurpose appointmentPurpose)
        {
            if (id != appointmentPurpose.Purpose_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _purposesRepository.UpdateAsync(appointmentPurpose);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentPurposeExists(appointmentPurpose.Purpose_Id))
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
            return View("~/Views/ManageLists/AppointmentPurposes/Edit.cshtml", appointmentPurpose);
        }

        // GET: AppointmentPurposes/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var appointmentPurpose = await _purposesRepository.GetbyIdAsync(id);
            if (appointmentPurpose == null)
            {
                return NotFound();
            }

            return View("~/Views/ManageLists/AppointmentPurposes/Delete.cshtml", appointmentPurpose);
        }

        // POST: AppointmentPurposes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_purposesRepository == null)
            {
                return Problem("Entity set 'CRMSDbContext'  is null.");
            }
            var appointmentPurpose = await _purposesRepository.GetbyIdAsync(id);
            if (appointmentPurpose != null)
            {
                await _purposesRepository.DeleteAsync(id);
            }
            
            
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentPurposeExists(Guid id)
        {
          return (_purposesRepository.GetbyIdAsync(id) is not null);
        }
    }
}
