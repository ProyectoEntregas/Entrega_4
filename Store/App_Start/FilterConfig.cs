using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalfilters(GlobalFilterCollection Filters)
        {
            Filters.Add(new Filters.VerificarSesion());
        }
    }
}