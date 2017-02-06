using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Manejadoras;
using BL;
using Modelos;
using System.Data.SqlClient;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Lista()
        {
            if (Request.Cookies.AllKeys.Contains("CookieUser"))
            {
                HttpCookie miCookie = Request.Cookies["CookieUser"];

            }
            ManejadoraBL misListados;

            try
            {
                misListados = new ManejadoraBL();
                List<clsPersona> miLista = misListados.obtenerListadoPersonasBL();
                return View(miLista);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User usuario)
        {
            if(String.IsNullOrEmpty(usuario.userName) || String.IsNullOrEmpty(usuario.password))
            {
                ViewBag.error = "No puede haber un campo vacio";

                return View();
            }
            else
            {

                if (Request.Cookies.AllKeys.Contains("CookieUser"))
                {
                    HttpCookie miCookie = Request.Cookies["CookieUser"];
                    miCookie.Expires = DateTime.Now.AddDays(7);
                    miCookie.Value = usuario.userName;
                    Response.Cookies.Add(miCookie);
                }
                else
                {
                    HttpCookie miCookie =  new HttpCookie("CookieUser");
                    miCookie.Expires = DateTime.Now.AddDays(7);
                    miCookie.Value = usuario.userName;
                    Response.Cookies.Add(miCookie);
                }

                ManejadoraBL manejadoraBL = new ManejadoraBL();
                return View("Lista",manejadoraBL.obtenerListadoPersonasBL());
            }
            
           
        }


        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            ManejadoraBL manejadoraBL = new ManejadoraBL();
            clsPersona oPersona = manejadoraBL.obtenerPersonaBL(id);

            return View(oPersona);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(clsPersona persona)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ManejadoraBL manejadoraBL = new ManejadoraBL();
                    manejadoraBL.insertarPersonaBL(persona);
                    return View("Lista", manejadoraBL.obtenerListadoPersonasBL());
                }
                else
                {
                    return View(persona);
                }

            }
            catch
            {
                return View(persona);
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            ManejadoraBL manejadoraBL = new ManejadoraBL();
            try
            {
                return View(manejadoraBL.obtenerPersonaBL(id));

            }
            catch (SqlException)
            {

                return View("Error");
            }

            
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(clsPersona persona)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ManejadoraBL manejadoraBL = new ManejadoraBL();
                    if (manejadoraBL.actualizarPersona(persona) == 0)
                    {
                        return View("Error");
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }

                }else
                {
                    return View(persona.id);
                }

                
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            ManejadoraBL manejadoraBL = new ManejadoraBL();
            
            return View(manejadoraBL.obtenerPersonaBL(id));
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,FormCollection collection)
        {
            try
            {
                ManejadoraBL manejadoraBL = new ManejadoraBL();
                manejadoraBL.borrarPersonaBL(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
