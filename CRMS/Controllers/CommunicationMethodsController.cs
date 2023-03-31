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
    public class CommunicationMethodsController : Controller
    {
        private readonly IRepository<CommunicationMethod> _methodsRepo;

        public CommunicationMethodsController(IRepository<CommunicationMethod> methods)
        {
            _methodsRepo = methods;
        }

        // GET: CommunicationMethods
        public async Task<IActionResult> Index()
        {
            return View(await _methodsRepo.GetAllAsync());
                          
        }

        // GET: CommunicationMethods/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var communicationMethod = await _methodsRepo.GetbyIdAsync(id);
                
            if (communicationMethod == null)
            {
                return NotFound();
            }

            return View(communicationMethod);
        }

        // GET: CommunicationMethods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommunicationMethods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommunicationMethod_Id,CommunicationMethodName")] CommunicationMethod communicationMethod)
        {
            if (ModelState.IsValid)
            {
                communicationMethod.CommunicationMethod_Id = Guid.NewGuid();
                await _methodsRepo.CreateAsync(communicationMethod);
                return RedirectToAction(nameof(Index));
            }
            return View(communicationMethod);
        }

        // GET: CommunicationMethods/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        { 
            var communicationMethod = await _methodsRepo.GetbyIdAsync(id);
            if (communicationMethod == null)
            {
                return NotFound();
            }
            return View(communicationMethod);
        }

        // POST: CommunicationMethods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CommunicationMethod_Id,CommunicationMethodName")] CommunicationMethod communicationMethod)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    
                    await _methodsRepo.UpdateAsync(communicationMethod);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommunicationMethodExists(communicationMethod.CommunicationMethod_Id))
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
            return View(communicationMethod);
        }

        // GET: CommunicationMethods/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var communicationMethod = await _methodsRepo.GetbyIdAsync(id);
            if (communicationMethod == null)
            {
                return NotFound();
            }

            return View(communicationMethod);
        }

        // POST: CommunicationMethods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_methodsRepo == null)
            {
                return Problem("Entity set 'CRMSDbContext.CommunicationMethods'  is null.");
            }
            var communicationMethod = await _methodsRepo.GetbyIdAsync(id);
            if (communicationMethod != null)
            {
                await _methodsRepo.DeleteAsync(id);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool CommunicationMethodExists(Guid id)
        {
          return (_methodsRepo.GetbyIdAsync(id) is not null);
        }
    }
}
