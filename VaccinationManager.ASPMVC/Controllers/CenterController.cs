using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;
using WebApplication1.Services.Base_Interface;

namespace WebApplication1.Controllers
{
    public class CenterController : Controller
    {
        //private readonly CenterService _service;
        private readonly IService<CenterModel> _service;

        public CenterController(IService<CenterModel> service)
        {
            _service = service;
        }

        // GET: CenterController
        public ActionResult Index()
        {
            IEnumerable<CenterModel> models = _service.GetAll();
            return View(models);
        }

        // GET: CenterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CenterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CenterController/Create
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

        // GET: CenterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CenterController/Edit/5
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

        // GET: CenterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CenterController/Delete/5
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
