﻿using ApiFacebook.Domain.Entity;
using ApiFacebook.InfraData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiFacebookNet.Controllers
{
    public class FriendController : Controller
    {

        FriendRepository _bd = new FriendRepository();
        
        // GET: Friend
        public ActionResult Index()
        {

                var result = _bd.GetFriends();
            
            return View(result);
        }

        // GET: Friend/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Friend/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friend/Create
        [HttpPost]
        public ActionResult Create(Friend friend)
        {
            try
            {

                _bd.InsertFriend(friend);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Friend/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Friend/Edit/5
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

        // GET: Friend/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Friend/Delete/5
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
