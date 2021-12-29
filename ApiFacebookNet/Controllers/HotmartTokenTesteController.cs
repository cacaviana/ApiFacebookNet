using ApiFacebook.Servicos.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiFacebookNet.Controllers
{
    public class HotmartTokenTesteController : Controller
    {
        AuthorizeTokenHotmart aut = new AuthorizeTokenHotmart();

        

        // GET: HotmartTokenTeste
        public ActionResult Index()
        {


            aut.Get();

            return View();
        }

        // GET: HotmartTokenTeste/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HotmartTokenTeste/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotmartTokenTeste/Create
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

        // GET: HotmartTokenTeste/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HotmartTokenTeste/Edit/5
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

        // GET: HotmartTokenTeste/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HotmartTokenTeste/Delete/5
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
