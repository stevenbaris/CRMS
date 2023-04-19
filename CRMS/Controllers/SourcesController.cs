using CRMS.Models.Customization;
using CRMS.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMS.Controllers
{
    [Authorize(Policy = "AdminPolicy")]
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
            return View("~/Views/Customization/Components/leadSource/Sources/Index.cshtml", await _sourceRepository.GetAllAsync());

        }

        // GET: Sources/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var source = await _sourceRepository.GetbyIdAsync(id);
            if (source == null)
            {
                return NotFound();
            }

            return View("~/Views/Customization/Components/leadSource/Sources/Details.cshtml", source);
        }

        // GET: Sources/Create
        public IActionResult Create()
        {
            return View("~/Views/Customization/Components/leadSource/Sources/Create.cshtml");
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
            return View("~/Views/Customization/Components/leadSource/Sources/Create.cshtml", source);
        }

        // GET: Sources/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {

            var source = await _sourceRepository.GetbyIdAsync(id);
            if (source == null)
            {
                return NotFound();
            }
            return View("~/Views/Customization/Components/leadSource/Sources/Edit.cshtml", source);
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
            return View("~/Views/Customization/Components/leadSource/Sources/Edit.cshtml", source);
        }

        // GET: Sources/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var source = await _sourceRepository.GetbyIdAsync(id);
            if (source == null)
            {
                return NotFound();
            }

            return View("~/Views/Customization/Components/leadSource/Sources/Delete.cshtml", source);
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
