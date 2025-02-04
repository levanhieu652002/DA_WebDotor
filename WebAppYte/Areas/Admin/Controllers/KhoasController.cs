﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebAppYte.Models;

namespace WebAppYte.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KhoasController : Controller
    {
        private readonly WebDatLichKhamContext db;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public KhoasController(WebDatLichKhamContext context, IHttpContextAccessor httpContextAccessor)
        {
            db = context;
            _httpContextAccessor = httpContextAccessor;
        }
        // GET: Admin/Khoa
        public ActionResult Index()
        {
            return View(db.Khoas.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Khoa khoa = db.Khoas.Find(id);
            if (khoa == null)
            {
                return NotFound();
            }
            return View(khoa);
        }

        // GET: Admin/Khoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Khoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Makhoa, Tenkhoa, Mota")] Khoa khoa)
        {
            if (ModelState.IsValid)
            {
                db.Khoas.Add(khoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khoa);
        }

        // GET: Admin/Khoas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Khoa khoa = db.Khoas.Find(id);
            if (khoa == null)
            {
                return NotFound();
            }

            return View(khoa);
        }

        // POST: Admin/Khoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Makhoa, Tenkhoa, Mota")] Khoa khoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khoa);
        }

        // GET: Admin/Khoas/Delete/5


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