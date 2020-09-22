using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarkomApp.Data;
using MarkomApp.Models;
using Microsoft.Extensions.Logging;
using MarkomApp.Shared.Dto;

namespace MarkomApp.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyInterface _company;
        private readonly ILogger<CompanyController> _logger;
        public CompanyController(ICompanyInterface company)
        {
            _company = company;
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
    }
}
