using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using registration.Models;

namespace registration.Controllers
{
    public class UserController : Controller
    {
        public UserModel objUser;
        public DBModel dbconn;
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                this.objUser = new UserModel();
                this.objUser.fname = collection["fname"].ToString();
                this.objUser.lname = collection["lname"].ToString();
                this.objUser.email = collection["emailadd"].ToString();
                this.objUser.tel = collection["contact"].ToString();
                this.objUser.st_addr = collection["street"].ToString();
                this.objUser.city = collection["city"].ToString();
                this.objUser.zip = collection["zip"].ToString();
                this.objUser.username = "fcipriano";
                this.objUser.password = "qwe123!@#";
                this.objUser.timestamp = System.DateTime.Now;
                this.objUser.AddUserEF();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}