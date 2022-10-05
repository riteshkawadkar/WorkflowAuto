using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkflowAuto.Contracts;
using WorkflowAuto.Data;
using WorkflowAuto.Models;

namespace WorkflowAuto.Controllers
{
    [Authorize]
    public class ApplicationsController : Controller
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;

        public ApplicationsController(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }

        // GET: Applications
        public async Task<IActionResult> Index()
        {
            //var applicationVMList = _mapper.Map<List<ApplicationIndexVM>>(await _applicationRepository.Applications.ToListAsync());
            var applicationVMList = _mapper.Map<List<ApplicationIndexVM>>(await _applicationRepository.GetAllAsync());
            return View(applicationVMList);
        }

        // GET: Applications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var application = await _applicationRepository.GetAsync(id);
            if (application == null)
            {
                return NotFound();
            }

            var applicationVM = _mapper.Map<ApplicationVM>(application);
            return View(applicationVM);
        }

        // GET: Applications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Applications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ApplicationVM applicationVM)
        {
            if (ModelState.IsValid)
            {
                var application = _mapper.Map<Application>(applicationVM);
                await _applicationRepository.CreateAsync(application);

                return RedirectToAction(nameof(Index));
            }
            return View(applicationVM);
        }

        // GET: Applications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var application = await _applicationRepository.GetAsync(id);
            if (application == null)
            {
                return NotFound();
            }

            var applicationVM = _mapper.Map<ApplicationVM>(application);
            return View(applicationVM);
        }

        // POST: Applications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ApplicationVM applicationVM)
        {
            if (id != applicationVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var application = _mapper.Map<Application>(applicationVM);
                    await _applicationRepository.UpdateAsync(application);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _applicationRepository.ExistsAsync(id))
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
            return View(applicationVM);
        }

        

        // POST: Applications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            await _applicationRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

 
    }
}
