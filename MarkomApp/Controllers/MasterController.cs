using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarkomApp.Data;
using MarkomApp.Shared.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarkomApp.Controllers
{
    [Route("[controller]")]
    //[ApiController]
    public class MasterController : Controller
    {
        private readonly ICompanyInterface _company;
        private readonly IEmployeeInterface _employee;
        private readonly IUserInterface _user;
        private readonly ILogger<MasterController> _logger;

        public MasterController(ILogger<MasterController> logger)
        {
            _logger = logger;
        }

        public MasterController(ICompanyInterface company)
        {
            _company = company;
        }
        public MasterController(IUserInterface user)
        {
            _user = user;
        }
        public MasterController(IEmployeeInterface employee)
        {
            _employee = employee;
        }

        // GET: MasterController
        public ActionResult Index()
        {
            return View();
        }


        #region Company
        //Get 
        [Route("{controller}/Company")]
        public ActionResult CompanyIndex()
        {
            var result = _company.GetCompanyList();
            return View(result);
        }

        [Route("{controller}/Company/Add")]
        //[HttpGet("")]
        public ActionResult CompanyAdd()
        {
            return View();
        }

        [Route("{controller}/Company/Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyAdd(CompanyDto model)
        {
            bool success = false;
            try
            {
                if (ModelState.IsValid)
                {
                    success = _company.AddCompany(model);
                }
            }
            catch
            {
                return View();
            }

            if (success)
                return RedirectToAction(nameof(CompanyIndex));
            else
                return View();
        }

        [Route("{controller}/Company/Edit")]
        public ActionResult CompanyEdit()
        {
            return View();
        }
        
        [Route("{controller}/Company/Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyEdit(CompanyDto model)
        {
            bool success = false;
            try
            {
                if (ModelState.IsValid)
                {
                    success = _company.EditCompany(model);
                }
            }
            catch
            {
                return View();
            }

            if (success)
                return RedirectToAction(nameof(CompanyIndex));
            else
                return View();
        }

        [Route("{controller}/Company/Detail")]
        public ActionResult CompanyDetail(int id)
        {
            return View();
        }

        [Route("{controller}/Company/Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyDelete(int id)
        {
            try
            {
                return RedirectToAction(nameof(CompanyIndex));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region User
        //Get 
        [Route("{controller}/User")]
        public ActionResult UserIndex()
        {
            return View();
        }

        [Route("{controller}/User/Add")]
        //[HttpGet("")]
        public ActionResult UserAdd()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserAdd(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(UserIndex));
            }
            catch
            {
                return View();
            }
        }

        [Route("{controller}/User/Edit")]
        public ActionResult UserEdit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserEdit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(UserIndex));
            }
            catch
            {
                return View();
            }
        }

        [Route("{controller}/User/Detail")]
        public ActionResult UserDetail(int id)
        {
            return View();
        }

        [Route("{controller}/User/Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserDelete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(UserIndex));
            }
            catch
            {
                return View();
            }
        }
        #endregion

    }
}
