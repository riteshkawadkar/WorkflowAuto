using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WorkflowAuto.Constants;
using WorkflowAuto.Data;
using WorkflowAuto.Models;

namespace WorkflowAuto.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> _usermanager;
        private readonly IMapper _mapper;

        public EmployeesController(UserManager<Employee> usermanager, IMapper mapper)
        {
            _usermanager = usermanager;
            _mapper = mapper;
        }

        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await _usermanager.GetUsersInRoleAsync(Roles.User);
            var employeesVM = _mapper.Map<List<EmployeeListVM>>(employees);
            return View(employeesVM);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
