using AutoMapper;
using CrudSimpleModalBootstrap.Models;
using Projeto.Domain;
using Projeto.Infra.DataContext;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
            return PartialView(new AutorViewModel());
        }

        public ActionResult AutorInserirPartial()
        {
            return PartialView("_AutorInserir", new AutorViewModel());
        }

        // POST: Autor/Create
        [HttpPost]
        public ActionResult Create(AutorViewModel model)
        {
            try
            {
                var autor = Mapper.Map<AutorViewModel, Autor>(model);
                if (autor == null)
                {
                    return HttpNotFound();
                }
                if (true)
                {
                    db.Autores.Add(autor);
                    db.SaveChanges();
                }                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Autor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var autor = db.Autores.Find(id);
            var model = Mapper.Map<Autor, AutorViewModel>(autor);
            if (model == null)
            {
                return HttpNotFound();
            }
            return PartialView(model);
        }

        public ActionResult AutorEditPartial(int id)
        {
            var model = new AutorViewModel();
            model.Id = id;
            return PartialView("_AutorEditar", model);
        }

        // POST: Autor/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, AutorViewModel model)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var modelAutor = new AutorViewModel();
            modelAutor.Id = id.Value;

            try
            {
                if (ModelState.IsValid)
                {
                    var entityOld = db.Autores.Find(model.Id);
                    var modelUpdate = Mapper.Map<AutorViewModel, Autor>(model, entityOld);
                    db.Entry(modelUpdate).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return PartialView("_AutorDetalhe", modelAutor);
            }
            catch
            {
                return PartialView("_AutorDetalhe", modelAutor);
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
