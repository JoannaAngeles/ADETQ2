using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ADETQ2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ADETQ2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        public StudentController (ApplicationDbContext db)
        {

            _db = db;
         } 

        public IActionResult Index()
        {
          var displaydata = _db.StudentTable.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(NewStudentInfo nec)

        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(nec);
        }
        public async Task <ActionResult> Edit (int? id )
        {
            if (id==null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.StudentTable.FindAsync(id);
            return View(getempdetails);

        }
        [HttpPost]

        public async Task <ActionResult> Edit (NewStudentInfo nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return View("Index");

            }
            return View(nc);
        }
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.StudentTable.FindAsync(id);
            return View(getempdetails);

        }
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getempdetails = await _db.StudentTable.FindAsync(id);
            return View(getempdetails);
        }
        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
           

            var getempdetails = await _db.StudentTable.FindAsync(id);
            _db.StudentTable.Remove(getempdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
