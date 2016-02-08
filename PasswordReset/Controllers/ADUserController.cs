using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.DirectoryServices;
using PasswordReset.Models;

namespace PasswordReset.Controllers
{
    public class AdUserController : Controller
    {
        // GET: ADUser
        public ActionResult Index()
        {
            var ent = new DirectoryEntry("LDAP://OU=testusers,DC=test,DC=local");

            //var mySearcher = new DirectorySearcher(ent, "sAMAccountName=test1*");
            //var ResEnt = mySearcher.FindAll();

            //var result = ResEnt[0].GetDirectoryEntry();

            //var whenChanged = result.Properties["whenChanged"].Value;
            //var pwdLastSet = result.Properties["pwdLastSet"].ToString();

            //result.Properties["sAMAccountName"].Value = "Test1Degisik";
            //var sAMAccountName = result.Properties["sAMAccountName"].Value;
            //var test = ent.Children.Find("dn=Kemal Test");

            var list = ent.Children.Cast<DirectoryEntry>().ToList();

            var userList = list.Select(user => new AdUser
            {
                SamAccountName = user.Properties["sAMAccountName"].Value.ToString(), Path = user.Path, WhenChanged = user.Properties["whenChanged"].Value.ToString()
            }).ToList();

            return View(userList);
        }

        // GET: ADUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ADUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ADUser/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ADUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ADUser/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ADUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ADUser/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
