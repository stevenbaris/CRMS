using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
    public class CommunicationMethodsController : Controller
    {
        private readonly IRepository<CommunicationMethod> _methodsRepo;

        public CommunicationMethodsController(IRepository<CommunicationMethod> methods)
        {
            _methodsRepo = methods;
        }
        //"~/Views/Customization/Components/CommsMethod/CommunicationMethods/Index.cshtml",
        // GET: CommunicationMethods
        public async Task<IActionResult> Index()
        {
            return View("~/Views/Customization/Components/CommsMethod/CommunicationMethods/Index.cshtml", await _methodsRepo.GetAllAsync());

        }

        // GET: CommunicationMethods/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var communicationMethod = await _methodsRepo.GetbyIdAsync(id);

            if (communicationMethod == null)
            {
                return NotFound();
            }

            return View("~/Views/Customization/Components/CommsMethod/CommunicationMethods/Details.cshtml", communicationMethod);
        }

        // GET: CommunicationMethods/Create
        public IActionResult Create()
        {
            return View("~/Views/Customization/Components/CommsMethod/CommunicationMethods/Create.cshtml");
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
            return View("~/Views/Customization/Components/CommsMethod/CommunicationMethods/Create.cshtml", communicationMethod);
        }

        // GET: CommunicationMethods/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            var communicationMethod = await _methodsRepo.GetbyIdAsync(id);
            if (communicationMethod == null)
            {
                return NotFound();
            }
            return View("~/Views/Customization/Components/CommsMethod/CommunicationMethods/Edit.cshtml", communicationMethod);
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
            return View("~/Views/Customization/Components/CommsMethod/CommunicationMethods/Edit.cshtml", communicationMethod);
        }

        // GET: CommunicationMethods/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var communicationMethod = await _methodsRepo.GetbyIdAsync(id);
            if (communicationMethod == null)
            {
                return NotFound();
            }

            return View("~/Views/Customization/Components/CommsMethod/CommunicationMethods/Delete.cshtml", communicationMethod);
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
