using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarkomApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarkomApp.Controllers
{
    //[Route("[controller]")]
    //[ApiController]
    public class MasterController : Controller
    {
        private readonly ILogger<MasterController> _logger;
        private readonly IMasterInterface _masterInterface;

        public MasterController(IMasterInterface masterInterface, ILogger<MasterController> logger)
        {
            _logger = logger;
            _masterInterface = masterInterface;
        }

        // GET: MasterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MasterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {



                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MasterController/Edit/5
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

        // GET: MasterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MasterController/Delete/5
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

        #region Company
        //Get 
        [Route("{controller}/Company")]
        public ActionResult CompanyIndex()
        {
            var result = _masterInterface.GetCompanyList();
            return View(result);
        }

        [Route("{controller}/Company/Add")]
        //[HttpGet("")]
        public ActionResult CompanyAdd()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyAdd(IFormCollection collection)
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

        [Route("{controller}/Company/Edit")]
        public ActionResult CompanyEdit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyEdit(int id, IFormCollection collection)
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

        [Route("{controller}/Company/Detail")]
        public ActionResult CompanyDetail(int id)
        {
            return View();
        }

        [Route("{controller}/Company/Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyDelete(int id, IFormCollection collection)
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
                return RedirectToAction(nameof(Index));
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
                return RedirectToAction(nameof(Index));
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
