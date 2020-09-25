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
    [Route("Master/[controller]")]
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
        //[Route("Master/Company")]
        public ActionResult Index()
        {
            var result = _company.GetCompanyList();
            return View(result);
        }

        [Route("Master/Company/Add")]
        //[HttpGet("")]
        public ActionResult CompanyAdd()
        {
            return View();
        }

        [Route("MasterCompany/Add")]
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
                return RedirectToAction(nameof(Index));
            else
                return View();
        }

        [Route("MasterCompany/Edit")]
        public ActionResult CompanyEdit(int id)
        {
            Company company = _company.GetCompany(id);
            return View(company);
        }

        [Route("MasterCompany/Edit")]
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
                return RedirectToAction(nameof(Index));
            else
                return View();
        }

        [Route("Master/Company/Detail/")]
        public ActionResult CompanyDetail(int id)
        {
            return View();
        }

        [Route("Master/Company/Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyDelete(int id)
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
        #endregion
    }
}
