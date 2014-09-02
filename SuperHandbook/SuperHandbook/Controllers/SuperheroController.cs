using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SuperHandbook.DBModel;

namespace SuperHandbook.Controllers
{
    public class SuperheroController : Controller
    {
        private SuperDBEntities db = new SuperDBEntities();

        // GET: /Superhero/
        public ActionResult Index()
        {
            var superheroes = db.Superheroes.Include(s => s.BaseofOperation).Include(s => s.Creator).Include(s => s.CurrentStatu).Include(s => s.Eye).Include(s => s.List).Include(s => s.MartialStatu).Include(s => s.MessageBoard).Include(s => s.Occupation);
            return View(superheroes.ToList());
        }

        // GET: /Superhero/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero superhero = db.Superheroes.Find(id);
            if (superhero == null)
            {
                return HttpNotFound();
            }
            return View(superhero);
        }

        // GET: /Superhero/Create
        public ActionResult Create()
        {
            ViewBag.BaseofOperationsId = new SelectList(db.BaseofOperations, "Id", "BaseType");
            ViewBag.creatorId = new SelectList(db.Creators, "Id", "Name");
            ViewBag.CurrentStatusId = new SelectList(db.CurrentStatus, "Id", "StatusType");
            ViewBag.EyesId = new SelectList(db.Eyes, "Id", "Color");
            ViewBag.Id = new SelectList(db.Lists, "Id", "Name");
            ViewBag.MartialstatusId = new SelectList(db.MartialStatus, "Id", "Id");
            ViewBag.Id = new SelectList(db.MessageBoards, "Id", "BoardName");
            ViewBag.OccupationId = new SelectList(db.Occupations, "Id", "JobType");
            return View();
        }

        // POST: /Superhero/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,RealName,CodeName,OccupationId,Birthplace,MartialstatusId,BaseofOperationsId,Origin,height,weight,Picture,imagepath,EyesId,creatorId,CurrentStatusId")] Superhero superhero)
        {
            if (ModelState.IsValid)
            {
                db.Superheroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BaseofOperationsId = new SelectList(db.BaseofOperations, "Id", "BaseType", superhero.BaseofOperationsId);
            ViewBag.creatorId = new SelectList(db.Creators, "Id", "Name", superhero.creatorId);
            ViewBag.CurrentStatusId = new SelectList(db.CurrentStatus, "Id", "StatusType", superhero.CurrentStatusId);
            ViewBag.EyesId = new SelectList(db.Eyes, "Id", "Color", superhero.EyesId);
            ViewBag.Id = new SelectList(db.Lists, "Id", "Name", superhero.Id);
            ViewBag.MartialstatusId = new SelectList(db.MartialStatus, "Id", "Id", superhero.MartialstatusId);
            ViewBag.Id = new SelectList(db.MessageBoards, "Id", "BoardName", superhero.Id);
            ViewBag.OccupationId = new SelectList(db.Occupations, "Id", "JobType", superhero.OccupationId);
            return View(superhero);
        }

        // GET: /Superhero/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero superhero = db.Superheroes.Find(id);
            if (superhero == null)
            {
                return HttpNotFound();
            }
            ViewBag.BaseofOperationsId = new SelectList(db.BaseofOperations, "Id", "BaseType", superhero.BaseofOperationsId);
            ViewBag.creatorId = new SelectList(db.Creators, "Id", "Name", superhero.creatorId);
            ViewBag.CurrentStatusId = new SelectList(db.CurrentStatus, "Id", "StatusType", superhero.CurrentStatusId);
            ViewBag.EyesId = new SelectList(db.Eyes, "Id", "Color", superhero.EyesId);
            ViewBag.Id = new SelectList(db.Lists, "Id", "Name", superhero.Id);
            ViewBag.MartialstatusId = new SelectList(db.MartialStatus, "Id", "Id", superhero.MartialstatusId);
            ViewBag.Id = new SelectList(db.MessageBoards, "Id", "BoardName", superhero.Id);
            ViewBag.OccupationId = new SelectList(db.Occupations, "Id", "JobType", superhero.OccupationId);
            return View(superhero);
        }

        // POST: /Superhero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,RealName,CodeName,OccupationId,Birthplace,MartialstatusId,BaseofOperationsId,Origin,height,weight,Picture,imagepath,EyesId,creatorId,CurrentStatusId")] Superhero superhero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(superhero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BaseofOperationsId = new SelectList(db.BaseofOperations, "Id", "BaseType", superhero.BaseofOperationsId);
            ViewBag.creatorId = new SelectList(db.Creators, "Id", "Name", superhero.creatorId);
            ViewBag.CurrentStatusId = new SelectList(db.CurrentStatus, "Id", "StatusType", superhero.CurrentStatusId);
            ViewBag.EyesId = new SelectList(db.Eyes, "Id", "Color", superhero.EyesId);
            ViewBag.Id = new SelectList(db.Lists, "Id", "Name", superhero.Id);
            ViewBag.MartialstatusId = new SelectList(db.MartialStatus, "Id", "Id", superhero.MartialstatusId);
            ViewBag.Id = new SelectList(db.MessageBoards, "Id", "BoardName", superhero.Id);
            ViewBag.OccupationId = new SelectList(db.Occupations, "Id", "JobType", superhero.OccupationId);
            return View(superhero);
        }

        // GET: /Superhero/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero superhero = db.Superheroes.Find(id);
            if (superhero == null)
            {
                return HttpNotFound();
            }
            return View(superhero);
        }

        // POST: /Superhero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Superhero superhero = db.Superheroes.Find(id);
            db.Superheroes.Remove(superhero);
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
