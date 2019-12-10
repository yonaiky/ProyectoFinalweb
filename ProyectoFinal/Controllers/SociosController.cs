using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoFinal.Contex;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class SociosController : Controller
    {
        private SotreContext db = new SotreContext();

        // GET: Socios
        public ActionResult Index()
        {
            return View(db.Socios.ToList());
        }

        // GET: Socios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // GET: Socios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Socios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SocioViewModel view)
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();               
            }
            string path = string.Empty;
            string pic = string.Empty;


            if (view.Foto != null )
            {
                pic = System.IO.Path.GetFileName(view.Foto.FileName);
                path = System.IO.Path.Combine(Server.MapPath("~/Content/Foto"), pic);
                view.Foto.SaveAs(path);
                using (MemoryStream ms = new MemoryStream())
                {
                    view.Foto.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }
            }

            var socio = new Socio
            {
                Nombre = view.Nombre,
                Apellido = view.Apellido,
                Cedula = view.Cedula,
                Foto = pic == string.Empty ? string.Empty : string.Format("~/Content/Foto/{0}",pic),
                Direccion = view.Direccion,
                Telefono = view.Telefono,
                Sexo = view.Sexo,
                Edad = view.Edad,
                FechaNacimiento = view.FechaNacimiento,
                Afiliados = view.Afiliados,
                Membresia = view.Membresia,
                LugarTrabajo = view.LugarTrabajo,
                DireccionOficina = view.DireccionOficina,
                TelefonoOficina = view.TelefonoOficina,
                EstadoMembresia = view.EstadoMembresia,
                FechaIngreso = view.FechaIngreso,
                FechaSalida = view.FechaSalida
                

            };
            db.Socios.Add(socio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Socios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // POST: Socios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SocioID,Nombre,Apellido,Cedula,Foto,Direccion,Telefono,Sexo,Edad,FechaNacimiento,Afiliados,Membresia,LugarTrabajo,DireccionOficina,TelefonoOficina,EstadoMembresia,FechaIngreso,FechaSalida")] Socio socio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socio);
        }

        // GET: Socios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // POST: Socios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Socio socio = db.Socios.Find(id);
            db.Socios.Remove(socio);
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
