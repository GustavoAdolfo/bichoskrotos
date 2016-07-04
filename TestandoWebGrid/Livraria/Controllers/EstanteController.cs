using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Livraria.Models;
using WebGrease.Css.Extensions;

namespace Livraria.Controllers
{
    public class EstanteController : Controller
    {
        // GET: Estante
        public ActionResult Index()
        {
            var listagem = new List<EdicaoModel>();

            string arquivo = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/dados.json");

            if (System.IO.File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        var json = sr.ReadToEnd();

                        var dados = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<LivroModel>>(json);

                        dados.ForEach(d => listagem.Add(d.Edicao));
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + "não foi localizaod !");
            }

            

            return View(listagem);
        }

        // GET: Estante/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estante/Create
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

        // GET: Estante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estante/Edit/5
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

        // GET: Estante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estante/Delete/5
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
