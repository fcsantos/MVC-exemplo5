using AutoMapper;
using CrudSimpleModalBootstrap.Models;
using Projeto.Domain;
using Projeto.Infra.DataContext;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CrudSimpleModalBootstrap.Controllers
{
    public class AutorController : Controller
    {
        private CRUDContext db = new CRUDContext();

        // GET: Autor
        public ActionResult Index()
        {
            var lstAutores = from a in db.Autores select a;
            var model = new List<AutorViewModel>();
            foreach (var a in lstAutores.ToList())
            {
                var item = Mapper.Map<Autor, AutorViewModel>(a);
                model.Add(item);
            }
            return View(model.AsEnumerable());
        }

        // GET: Autor/Details/5
        public ActionResult Detalhe(int id)
        {
            var autor = db.Autores.Find(id);
            var model = Mapper.Map<Autor, AutorViewModel>(autor);            
            return PartialView(model);
        }

        public ActionResult AutorDetalhePartial(int id)
        {
            var model = new AutorViewModel();
            model.Id = id;           
            return PartialView("_AutorDetalhe", model);
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
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

        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Autor/Edit/5
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

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Autor/Delete/5
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
