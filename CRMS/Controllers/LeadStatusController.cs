using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
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
            return View("~/Views/Customization/Components/LeadStatus/LeadStatus/Index.cshtml", await _leadStatusRepository.GetAllAsync());

        }

        // GET: LeadStatus/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var leadStatus = await _leadStatusRepository.GetbyIdAsync(id);
            if (leadStatus == null)
            {
                return NotFound();
            }

            return View("~/Views/Customization/Components/LeadStatus/LeadStatus/Details.cshtml", leadStatus);
        }

        // GET: LeadStatus/Create
        public IActionResult Create()
        {
            return View("~/Views/Customization/Components/LeadStatus/LeadStatus/Create.cshtml");
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
            return View("~/Views/Customization/Components/LeadStatus/LeadStatus/Create.cshtml", leadStatus);
        }

        // GET: LeadStatus/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var leadStatus = await _leadStatusRepository.GetbyIdAsync(id);
            if (leadStatus == null)
            {
                return NotFound();
            }
            return View("~/Views/Customization/Components/LeadStatus/LeadStatus/Edit.cshtml", leadStatus);
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
            return View("~/Views/Customization/Components/LeadStatus/LeadStatus/Edit.cshtml", leadStatus);
        }

        // GET: LeadStatus/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var leadStatus = await _leadStatusRepository.GetbyIdAsync(id);
            if (leadStatus == null)
            {
                return NotFound();
            }

            return View("~/Views/Customization/Components/LeadStatus/LeadStatus/Delete.cshtml", leadStatus);
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
