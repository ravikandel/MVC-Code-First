using codefirstdemo.Models;
using codefirstdemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codefirstdemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        private IRepository<Employee> _repository = null;
        public EmployeeController()
        {
            this._repository = new Repository<Employee>();
        }

        public ActionResult Index()
        {
            var employees = _repository.GetAll();
            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = _repository.GetById(id);
            return View(employee); 
        }

        // GET: Employee/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(employee);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(employee);
            }  
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = _repository.GetById(id);
            return View(employee);  
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(employee);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(employee);
            }  
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = _repository.GetById(id);
            return View(employee);  
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(int Id)
        {
            var employee = _repository.GetById(Id);
            _repository.Delete(Id);
            _repository.Save();
            return RedirectToAction("Index");
        } 
    }
}
