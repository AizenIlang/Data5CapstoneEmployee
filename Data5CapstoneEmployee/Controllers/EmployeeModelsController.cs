using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data5CapstoneEmployee.Models;

namespace Data5CapstoneEmployee.Controllers
{
    public class EmployeeModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EmployeeModels
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        // GET: EmployeeModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeModels employeeModels = db.EmployeeModels.Find(id);
            if (employeeModels == null)
            {
                return HttpNotFound();
            }
            return View(employeeModels);
        }

        // GET: EmployeeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeNumber,Department,Education,Gender,Age,JobLevel,JobRole,MaritalStatus,NumCompaniesWorked,PerformanceRating,TrainingTimeLastYear,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurr4,JobSatisfaction,EnvironmentSatisfaction,WorkLifeBalance,EmployeeCount")] EmployeeModels employeeModels)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeModels.Add(employeeModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeModels);
        }

        // GET: EmployeeModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeModels employeeModels = db.EmployeeModels.Find(id);
            if (employeeModels == null)
            {
                return HttpNotFound();
            }
            return View(employeeModels);
        }

        // POST: EmployeeModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeNumber,Department,Education,Gender,Age,JobLevel,JobRole,MaritalStatus,NumCompaniesWorked,PerformanceRating,TrainingTimeLastYear,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurr4,JobSatisfaction,EnvironmentSatisfaction,WorkLifeBalance,EmployeeCount")] EmployeeModels employeeModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeModels);
        }

        // GET: EmployeeModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeModels employeeModels = db.EmployeeModels.Find(id);
            if (employeeModels == null)
            {
                return HttpNotFound();
            }
            return View(employeeModels);
        }

        // POST: EmployeeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeModels employeeModels = db.EmployeeModels.Find(id);
            db.EmployeeModels.Remove(employeeModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
