using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
       
        public ActionResult Login(string User,string Pass)
        {
            Variables ob = new Variables();
            try
            {
                using (Models.Data db=new Models.Data())
                {
                    var oUser = (from d in db.Usuario
                                 where d.Nickusuario == User.Trim() && d.Contra == Pass.Trim()
                                 select d).FirstOrDefault();
                   

                    if (oUser == null )
                    {
                        ViewBag.Error = "Usuario o contraseña incorrecta";
                        return View();
                    }
                   
                  

                      Session["User"] = oUser;
                }
                 return RedirectToAction("Index","Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
            
        }
    }
}