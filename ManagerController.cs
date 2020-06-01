using SPTBusinessLayer.Interfaces;
using SPTEntities.DatabaseEntities;
using SPTEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPT.Areas.Manager.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public ManagerController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                ManagerViewModel model = new ManagerViewModel();
                // To do - get employeee id of the logged in user
                // to do - add javascript to change the percent increase percents when a new rating is put in
                // to do - save data
                // to do - prevent user from inputing an increase amount for a bad rating
                // to do - lock worksheet when complete review is submitted, verify all employees have a rating
                model = _employeeService.GetEmployeesByReportsToId(130716, out List<EmployeeType> employeeTypeList);

                return View(model);
            } catch (Exception e)
            {
                ManagerViewModel model = new ManagerViewModel();
                return View(model);
            }            
        }

        [HttpPost]
        public ActionResult Index(ManagerViewModel model)
        {
            try
            {
                return View(model);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }
    }
}