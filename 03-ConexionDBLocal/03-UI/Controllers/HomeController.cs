using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _03_BL;
using _03_ConexionDBLocal_ET;
using _03_DAL.Manejadoras;

namespace _03_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            clsListadosPersonasBL misListados;

            try
            {
                misListados = new clsListadosPersonasBL();
                return View(misListados.getListadoPersonasBL());
            }
            catch (Exception)
            {
                return View("Error");
            }     
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(clsPersona persona)
        {
            int i;
            if (!ModelState.IsValid)
            {
                return View(persona);
            }else
            {
                try
                {
                    clsManejadoraPersonaBL omanejadoraPersona = new clsManejadoraPersonaBL();
                    i = omanejadoraPersona.insertarPersonaBL(persona);

                    clsListadosPersonasBL oListadoPersonasBL = new clsListadosPersonasBL();
                    return View("Index",oListadoPersonasBL.getListadoPersonasBL());
                }
                catch (Exception)
                {

                    return View("Error");
                }
            }   
        }


        public ActionResult Delete(int id)
        {
            clsPersona oPersona = new clsPersona();
            clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();

            try
            {
                oPersona = oManejadoraPersonaBL.getPersonaBL(id);
                return View(oPersona);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }


        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            int resultado;
            clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();

            resultado = oManejadoraPersonaBL.deletePersona(id);
            if (resultado == 0)
            {
                return View("Error");
            }
            else
            {
                clsListadosPersonasBL oListdosPersonas = new clsListadosPersonasBL();
                return View("Index",oListdosPersonas.getListadoPersonasBL());
            }
        }

        public ActionResult Edit(int id)
        {
            clsPersona oPersona = new clsPersona();
            clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();

            try
            {
                oPersona = oManejadoraPersonaBL.getPersonaBL(id);
                return View(oPersona);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost,ActionName("Edit")]
        public ActionResult EditConfirm(clsPersona oPersona)
        {

            if (!ModelState.IsValid)
            {
                return View(oPersona);
            }
            else {
                int resultado;
                clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();

                resultado = oManejadoraPersonaBL.updatePersona(oPersona);
                if (resultado == 0)
                {
                    return View("Error");
                }
                else
                {
                    clsListadosPersonasBL oListdosPersonas = new clsListadosPersonasBL();
                    return View("Index", oListdosPersonas.getListadoPersonasBL());
                }
            }

           
        }

        public ActionResult Details(int id)
        {
            clsManejadoraPersonaBL oManejadoraPersonaBL = new clsManejadoraPersonaBL();

            clsPersona oPersona = oManejadoraPersonaBL.getPersonaBL(id);
            return View(oPersona);
        }
    }
}