using Jey.Entities;
using Jey.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jey.Controllers
{
    public class marksController : Controller
    {
        // GET: marks
        public ActionResult Index()
        {

            return View();
        }
        public JsonResult GetStudentMarks()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                List<prestamos> lstMarks = new List<prestamos>();
                lstMarks = db.Marks.ToList();
                return Json(new { Result = "OK", Records = lstMarks }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
        [HttpPost]
        public JsonResult Create(prestamos Model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                Model.Id = Guid.NewGuid().ToString();
                db.Marks.Add(Model);
                db.SaveChanges();
                return Json(new { Result = "OK", Records = Model }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
        [HttpPost]
        public JsonResult Edit(prestamos Model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                db.Entry(Model).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { Result = "OK" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
        [HttpPost]
        public JsonResult Delete(String Id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            try
            {
                prestamos marks = db.Marks.Find(Id);
                db.Marks.Remove(marks);
                db.SaveChanges();
                return Json(new { Result = "OK" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
        }
}