using DigitalRetailersInc.DAL;
using DigitalRetailersInc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalRetailersInc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View(_unitOfWork.GetRepositoryInstance<laptop>().GetProduct());
        }

        public ActionResult ProductEdit(int laptop_id)
        {
            return View(_unitOfWork.GetRepositoryInstance<laptop>().GetFirstorDefault(laptop_id));
        }

        [HttpPost]
        public ActionResult ProductEdit(laptop tbl)
        {
            _unitOfWork.GetRepositoryInstance<laptop>().Update(tbl);
            return RedirectToAction("Product");
        }
        public ActionResult ProductAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductAdd(laptop tbl)
        {
            _unitOfWork.GetRepositoryInstance<laptop>().Add(tbl);
            return RedirectToAction("Product");
        }

        public ActionResult Customers()
        {
            return View(_unitOfWork.GetRepositoryInstance<member>().GetProduct());
        }
        public ActionResult CustomerEdit(int member_id)
        {
            return View(_unitOfWork.GetRepositoryInstance<member>().GetFirstorDefault(member_id));
        }

        [HttpPost]
        public ActionResult CustomerEdit(member tbl)
        {
            _unitOfWork.GetRepositoryInstance<member>().Update(tbl);
            return RedirectToAction("Product");
        }
    }
}