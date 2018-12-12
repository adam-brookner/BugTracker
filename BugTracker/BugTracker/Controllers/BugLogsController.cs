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
    public class BugLogsController : Controller
    {
        private IBugRepository bugRepository = null;

        public BugLogsController()
            :this(new BugRepository())
        { }

        public BugLogsController(BugRepository bugRepository)
        {
            this.bugRepository = bugRepository;
        }

        // GET: BugLogs
        public ActionResult Index()
        {
            IEnumerable<BugLog> bugs = bugRepository.GetAllBugs();
            ViewBag.Message = "BugLog";
            return View(bugs);
        }

        // GET: BugLogs/Details/5
        public ActionResult Details(int id)
        {
            BugLog bug = bugRepository.GetBugByID(id);
            ViewBag.Threads = bugRepository.GetBugByID(id);
            ViewBag.Message = "Forum Detail";
            return View(bug);
        }

        // GET: BugLogs/Create
        public ActionResult Create()
        {
            BugLog bug = new BugLog();
            return View(bug);
        }

        // POST: BugLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(BugLog bug)
        {
            try
            {
                // TODO: Add insert logic here
                bugRepository.AddBug(bug);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(bug);
            }
        }

        // GET: BugLogs/Edit/5
        public ActionResult Edit(int id)
        {
            BugLog bug = bugRepository.GetBugByID(id);
            return View(bug);
        }

        // POST: BugLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(BugLog bug)
        {
            try
            {
                // TODO: Add update logic here
                bugRepository.UpdateBug(bug);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(bug);
            }
        }

        // GET: BugLogs/Delete/5
        public ActionResult Delete(int id)
        {
            BugLog bug = bugRepository.GetBugByID(id);
            return View(bug);
        }

        // POST: BugLogs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            BugLog bug = bugRepository.GetBugByID(id);
           try
            {
                bugRepository.DeleteBug(bug);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(bug);
            }
        }
    }
}
