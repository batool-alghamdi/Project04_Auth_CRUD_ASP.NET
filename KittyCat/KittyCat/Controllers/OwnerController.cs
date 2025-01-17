﻿using KittyCat.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KittyCat.Data;

namespace KittyCat.Controllers
{
    public class OwnerController : Controller
    {

        private ApplicationDbContext _db;
        public OwnerController(ApplicationDbContext context)
        {
            _db = context;
        }
        public IActionResult Index(int id)
        {
            var Owners = _db.owner.ToList();
            ViewData["Owners"] = Owners;
            return View();
        }
        //GET - /Products/create
        public IActionResult Create()
        {
            return View();
        }
        //POST - /Products/create
        [HttpPost]
        public IActionResult Create([Bind("name", "age", "gender", "image","reason", "email", "phone")] OwnerModel owner)
        {
            _db.owner.Add(owner);
            _db.SaveChanges();

            ViewBag.OwnerId = owner.id;
            return View("AddCat");
        }
        [HttpPost]
        public IActionResult AddCat([Bind("OwnerId" ,"name", "age", "gender", "image", "breed", "description", "health" , "LocationId")] CatModel Cat)
        {
            _db.catTable.Add(Cat);
            _db.SaveChanges();
            return RedirectToAction("Index" , "Cats");
        }
        //GET- /Products/edit/id
        public IActionResult Edit(int id)
        {
            var owner = _db.owner.First(owner => owner.id == id);
            if (id == null || owner == null)
            {
                return View("Not_Found");
            }
            ViewData["owner"] = owner;
            return View();
        }
        // POST
        [HttpPost]
        public IActionResult Edit([Bind("id", "name", "age", "gender", "reason","image", "email", "phone")] OwnerModel owner)
        {
            // if i used this header and passed the id through the URL Edit(int id , [Bind("ProductId", "Name", "Price", "Description")] Product prod)


            /* var Product = _db.Products.ToList().Find(product => product.ProductId == id);
             Product.Name = prod.Name;
             Product.Description = prod.Description;
             Product.Price = prod.Price;

             _db.Products.Update(Product);
             _db.SaveChanges();*/

            _db.owner.Update(owner);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        //POST /products/delete/id
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var owner = _db.owner.First(owner => owner.id == id);
            var cats = _db.catTable.Where(c => c.OwnerId == owner.id).ToList();

            foreach (var c in cats) _db.catTable.Remove(c);

            _db.owner.Remove(owner);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
