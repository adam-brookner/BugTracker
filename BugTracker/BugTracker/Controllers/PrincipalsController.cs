using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BugTracker.Models;

namespace BugTracker.Controllers
{
    public class PrincipalsController : Controller
    {
        private BugEntities db = new BugEntities();
        private IBugRepository bugRepository = null;
        public PrincipalsController()
        :this(new BugRepository())
        {

        }
        public PrincipalsController(BugRepository bugRepository)
        {
            this.bugRepository = bugRepository;
        }
        // GET: Principals
        public ActionResult Index(string searchString)
        {
            var principals = from p in db.Principals select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                principals = principals.Where(p => p.Forename.Contains(searchString) || p.Surname.Contains(searchString));
            }
            return View(principals.ToList());
        }

        // GET: Principals/Details/5
        public ActionResult Details(int id)
        {
            Principal principal = bugRepository.GetPrincipalByID(id);
            ViewBag.Principals = bugRepository.GetPrincipalByID(id);
            ViewBag.Message = "Principal Detail";
            return View(principal);
        }

        // GET: Principals/Create
        public ActionResult Create()
        {
            Principal principal = new Principal();
            return View(principal);
        }

        // POST: Principals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(Principal principal)
        {
            try
            {
                // TODO: Add insert logic here
                bugRepository.AddPrincipal(principal);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(principal);
            }
        }

        // GET: Principals/Edit/5
        public ActionResult Edit(int id)
        {
            Principal principal = bugRepository.GetPrincipalByID(id);
            return View(principal);
        }

        // POST: Principals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(Principal principal)
        {
            try
            {
                // TODO: Add update logic here
                bugRepository.UpdatePrincipal(principal);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(principal);
            }
        }

        // GET: Principals/Delete/5
        public ActionResult Delete(int id)
        {
            Principal principal = bugRepository.GetPrincipalByID(id);
            return View(principal);
        }

        // POST: Principals/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Principal principal = bugRepository.GetPrincipalByID(id);
            try
            {
                bugRepository.DeletePrincipal(principal);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(principal);
            }
        }
    }
}
